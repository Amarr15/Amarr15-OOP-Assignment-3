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

## Step 3 — Why GetById does not compile

### Compiler error

`CS1061: 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found`

### Explanation

The compiler does not know that the generic type `T` has an `Id` property.

`T` can represent any type, and not every type has an `Id`.

For example, `Student` and `Course` have an `Id`, but `string` and `int` do not.

Therefore, the compiler cannot allow `item.Id` until we tell it that `T` must have an `Id`.






