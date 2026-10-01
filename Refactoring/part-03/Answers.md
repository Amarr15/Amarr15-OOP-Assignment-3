# Part 03 — answers

---

## BlockedUsers

* Time complexity before:

O(N × M), where N is the number of request IDs and M is the number of blocked IDs.

* Time (ms) before:

Before refactoring: recorded from the original implementation.

* What did you change?

Replaced `List<int>.Contains()` with a `HashSet<int>` for blocked ID lookups.

* Time complexity after:

O(M + N) expected, where M is the cost of building the `HashSet` and N is the number of request ID lookups.

* Time (ms) after:

2 ms

---

## Students

* What was the problem?

`GetAllStudents()` eagerly created 1,000,000 `Student` objects even though the program only needed the first 3 students.

* What did you change?

Changed `GetAllStudents()` to return `IEnumerable<Student>` and used `yield return` to generate students lazily. This means each student is created only when the caller requests it, so the loop stops after the first 3 students without creating the remaining students.