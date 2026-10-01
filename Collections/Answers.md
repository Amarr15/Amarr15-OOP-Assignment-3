# Task 2.2 — Pick the Collection

## S1 — Find a student by national ID

**Collection:** `Dictionary<string, Student>`

**Why:** `Dictionary` provides fast lookup by a unique key such as the student's national ID.

---

## S2 — Keep the tags of a course

**Collection:** `HashSet<string>`

**Why:** `HashSet` stores unique values and prevents the same tag from being stored twice.

---

## S3 — Keep a student's grades in the order they were entered

**Collection:** `List<decimal>`

**Why:** `List` preserves insertion order and allows duplicate grades.

---

## S4 — A public method returns the course price list

**Collection:** `IReadOnlyDictionary<string, decimal>`

**Why:** `IReadOnlyDictionary` allows callers to read prices by key without adding, removing, or changing entries through the returned collection.

---

## S5 — A timetable keyed by session start time

**Collection:** `SortedDictionary<TimeOnly, string>`

**Why:** `SortedDictionary` keeps entries ordered by their keys, so sessions are always printed in start-time order.

---

## S6 — A method returns results that the caller only loops over once

**Collection:** `IEnumerable<T>`

**Why:** `IEnumerable` supports sequential iteration and can generate results lazily, allowing the caller to stop early.
