# Generics Answers

## Step 2 — StudentStore vs CourseStore

### What is the same?

Both `StudentStore` and `CourseStore`:

- Keep their items in a `List`.
- Have an `Add` method.
- Have a `GetById` method that searches by `Id`.
- Have a `GetAll` method.
- Have a `Remove` method.
- Use the same basic logic for adding, finding, retrieving, and removing items.

### What is different?

`StudentStore` works only with `Student` objects, while `CourseStore` works only with `Course` objects.

`Student` has:

- `Id`
- `Name`

`Course` has:

- `Id`
- `Title`
- `Price`

So the main difference is the type of object each store manages and the properties of that object.