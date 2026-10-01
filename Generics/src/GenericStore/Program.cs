var studentStore = new Store<Student>();

studentStore.Add(new Student
{
    Id = 1,
    Name = "Ammar"
});

studentStore.Add(new Student
{
    Id = 2,
    Name = "Ahmed"
});

var student = studentStore.GetById(2);

Console.WriteLine(student?.Name);

var courseStore = new Store<Course>();

courseStore.Add(new Course
{
    Id = 1,
    Title = "C#",
    Price = 500
});

courseStore.Add(new Course
{
    Id = 2,
    Title = "ASP.NET Core",
    Price = 700
});

var course = courseStore.GetById(2);

Console.WriteLine($"{course?.Title} - {course?.Price}");