public class CourseStore

{
    private readonly List<Course> _courses = new();

    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public Course? GetById(int id)
    {
        foreach (var course in _courses)
        {
            if (course.Id == id)
                return course;
        }

        return null;
    }

    public List<Course> GetAll()
    {
        return _courses;
    }

    public void Remove(int id)
    {
        var course = GetById(id);

        if (course != null)
            _courses.Remove(course);
    }
}