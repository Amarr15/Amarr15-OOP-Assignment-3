public static class EnumerableExtensions
{
    public static IEnumerable<T> Page<T>(
        this IEnumerable<T> source,
        int pageNumber,
        int pageSize)
    {
        if (pageNumber < 1)
            throw new ArgumentOutOfRangeException(
                nameof(pageNumber),
                "Page number must be greater than 0.");

        if (pageSize < 1)
            throw new ArgumentOutOfRangeException(
                nameof(pageSize),
                "Page size must be greater than 0.");

        int skip = (pageNumber - 1) * pageSize;
        int index = 0;
        int returned = 0;

        foreach (var item in source)
        {
            if (index < skip)
            {
                index++;
                continue;
            }

            if (returned >= pageSize)
                yield break;

            yield return item;

            index++;
            returned++;
        }
    }

    public static T? FindById<T>(
    this IEnumerable<T> source,
    int id)
    where T : IHasId
{
        foreach (var item in source)
        {
            if (item.Id == id)
                return item;
        }

        return default;
    }

    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(
    this IEnumerable<T> source)
    where T : IHasId
{
        var dictionary = new Dictionary<int, T>();

        foreach (var item in source)
        {
            dictionary[item.Id] = item;
        }
        
        return dictionary;
    }
}