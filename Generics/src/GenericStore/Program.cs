var store = new StudentStore();

store.Add(new Student { Id = 1, Name = "Ammar" });
store.Add(new Student { Id = 2, Name = "Ahmed" });
store.Add(new Student { Id = 3, Name = "Mohamed" });

var student = store.GetById(2);

Console.WriteLine(student?.Name);

store.Remove(2);

Console.WriteLine(store.GetById(2)?.Name ?? "Student not found");