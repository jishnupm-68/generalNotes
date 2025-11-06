# day3

> Out parameter
out parameters are a way for a method to return multiple values.
They allow a method to send data back to the caller through parameters, in addition to the normal return value.
eg: static void test(int a, int b, out int num, out string data)

> Reference Parameter
Do the same as that of out parameter, but here it also modifies the actual parameter since we are using its reference.

| Feature                        | `ref`                                                        | `out`                                                         |
| ------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------- |
| **Purpose**                    | Used to **modify an existing value**                         | Used to **return multiple values** from a method              |
| **Initialization before call** | ✅ Required — variable **must be initialized** before passing | ❌ Not required — variable **can be uninitialized**            |
| **Assignment inside method**   | ❌ Optional — method may or may not assign a new value        | ✅ Mandatory — method **must assign** a value before returning |
| **Number of uses**             | Both declaration and call must include `ref`                 | Both declaration and call must include `out`                  |
| **Use case example**           | Adjusting or updating an existing variable                   | Returning extra data from a method                            |
| **Common examples**            | Modifying counters, updating flags                           | Parsing, calculations, multiple return values                 |
| **Runtime check**              | Compiler ensures variable initialized before method call     | Compiler ensures variable assigned before method return       |


>> Exercise: triangle area

> Exception Handling
handling the unexpected behaviour of our code from crashing
--> eg : trycatch

> Debugging using vs code
--> We can put the break points on where ever it requires and observe the behaviour of our code.
--> local/auto window
--> Watch window


#### Structures *** core of Object Oriented Programming" 
-> custom datatype
-> we can also use this type as the return type of our function

#### Classes *** core of Object Oriented Programming
-> a class is a blueprint for creating objects
-> A class defines properties (data) and methods (behavior).

Class vs Struct

| Feature                 | **Class**                                          | **Struct**                                         |
| ----------------------- | -------------------------------------------------- | -------------------------------------------------- |
| **Type**                | Reference type                                     | Value type                                         |
| **Memory location**     | Stored on the **Heap**                             | Stored on the **Stack**                            |
| **Assignment behavior** | Copies the *reference* (both refer to same object) | Copies the *entire value* (creates a new copy)     |
| **Default constructor** | Can define your own                                | Cannot define a parameterless constructor          |
| **Inheritance**         | Supports inheritance                               | ❌ Cannot inherit another struct/class              |
| **Interfaces**          | Can implement interfaces                           | ✅ Can also implement interfaces                    |
| **Null assignment**     | Can be `null`                                      | ❌ Cannot be `null` (unless declared as `Nullable`) |
| **Performance**         | Slightly slower (heap allocation + GC)             | Faster for small, short-lived data                 |
| **Usage**               | For large, complex objects                         | For lightweight data containers    



# Access modifiers

| Modifier                          | Access Level                      | Accessible From                                                 | Common Use                                            |
| --------------------------------- | --------------------------------- | --------------------------------------------------------------- | ----------------------------------------------------- |
| **public**                        | 🔓 No restriction                 | Anywhere (same class, other classes, other assemblies)          | When the member should be accessible globally         |
| **private**                       | 🔒 Most restrictive               | Only within the same class                                      | For hiding implementation details                     |
| **protected**                     | 🧩 Class + Derived classes        | The same class and its subclasses                               | When you want to expose members only to subclasses    |
| **internal**                      | 🏠 Within the same assembly       | Any class in the same project (assembly), not outside           | Used when multiple classes in one project share logic |
| **protected internal**            | 🔐 protected + internal           | Accessible from derived classes **or** classes in same assembly | Combination of both scopes                            |
| **private protected** *(C# 7.2+)* | 🔒 protected + same assembly only | Accessible only by derived classes **in the same assembly**     | Even more restricted than protected internal          |
                |
