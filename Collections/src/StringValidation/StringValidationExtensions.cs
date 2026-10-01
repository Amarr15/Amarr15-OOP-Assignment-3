using System.Text.RegularExpressions;

public static class StringValidationExtensions
{
    public static bool IsValidEgyptianPhone(this string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return false;

        var regex = new Regex(@"^(?:0|\+20)1[0125]\d{8}$");

        return regex.IsMatch(value);
    }

    public static bool IsValidEgyptianNationalId(this string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return false;

        var regex = new Regex(@"^[23]\d{13}$");

        return regex.IsMatch(value);
    }
}