var store = new CourseStore();

store.Add(new Course
{
    Id = 1,
    Title = "C#",
    Price = 500
});

store.Add(new Course
{
    Id = 2,
    Title = "ASP.NET Core",
    Price = 700
});

var course = store.GetById(2);

Console.WriteLine($"{course?.Title} - {course?.Price}");

store.Remove(2);

Console.WriteLine(
    store.GetById(2)?.Title ?? "Course not found");