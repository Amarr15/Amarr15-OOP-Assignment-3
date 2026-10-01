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

studentStore.Add(new Student
{
    Id = 3,
    Name = "Mohamed"
});

studentStore.Add(new Student
{
    Id = 4,
    Name = "Ali"
});

studentStore.Add(new Student
{
    Id = 5,
    Name = "Omar"
});

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

courseStore.Add(new Course
{
    Id = 3,
    Title = "SQL Server",
    Price = 600
});


Console.WriteLine("=== GetById ===");

var student = studentStore.GetById(2);
Console.WriteLine($"Student: {student?.Name}");

var course = courseStore.GetById(2);
Console.WriteLine($"Course: {course?.Title}");


Console.WriteLine();
Console.WriteLine("=== Duplicate Student ===");

try
{
    studentStore.Add(new Student
    {
        Id = 2,
        Name = "Another Ahmed"
    });
}
catch (InvalidOperationException ex)
{
    Console.WriteLine(ex.Message);
}


Console.WriteLine();
Console.WriteLine("=== Page 2 (Size 2) ===");

foreach (var item in studentStore.GetAll().Values.Page(2, 2))
{
    Console.WriteLine($"{item.Id} - {item.Name}");
}


Console.WriteLine();
Console.WriteLine("=== FindById on List<Course> ===");

var courses = new List<Course>
{
    new Course
    {
        Id = 1,
        Title = "C#",
        Price = 500
    },
    new Course
    {
        Id = 2,
        Title = "ASP.NET Core",
        Price = 700
    },
    new Course
    {
        Id = 3,
        Title = "SQL Server",
        Price = 600
    }
};

var foundCourse = courses.FindById(3);

Console.WriteLine(
    foundCourse != null
        ? $"{foundCourse.Id} - {foundCourse.Title}"
        : "Course not found");


Console.WriteLine();
Console.WriteLine("=== ToIdDictionary ===");

var studentDictionary = studentStore.GetAll().Values.ToIdDictionary();

foreach (var item in studentDictionary)
{
    Console.WriteLine($"{item.Key} - {item.Value.Name}");
}
