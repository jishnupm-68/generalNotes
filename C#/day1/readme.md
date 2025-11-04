=> Installation of vscode and backend development supporting components

# first program -> Hello world
    * Console present in System
    eg : Console.WriteLine("Hello world" ); ->Example for printing
         string name =  Console.ReadLine(); ->Acessing input from the user 

# numberic data types
    int age = 23;   -> declaring and initializing variable in single line
    int age;        -> declaring 
    age = 12;       -> initializing variable

# Integer
    | Type     | Size (bits) | Range                                                   | Example                     |
| -------- | ----------- | ------------------------------------------------------- | --------------------------- |
| `sbyte`  | 8           | -128 to 127                                             | `sbyte a = -100;`           |
| `byte`   | 8           | 0 to 255                                                | `byte b = 200;`             |
| `short`  | 16          | -32,768 to 32,767                                       | `short s = 12000;`          |
| `ushort` | 16          | 0 to 65,535                                             | `ushort us = 50000;`        |
| `int`    | 32          | -2,147,483,648 to 2,147,483,647                         | `int x = 100000;`           |
| `uint`   | 32          | 0 to 4,294,967,295                                      | `uint ux = 4000000000;`     |
| `long`   | 64          | -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 | `long l = 9000000000L;`     |
| `ulong`  | 64          | 0 to 18,446,744,073,709,551,615                         | `ulong ul = 18000000000UL;` |
| `char`   | 16          | Unicode characters (U+0000 to U+FFFF)                   | `char c = 'A';`             |



# Floating point numbers
| Type      | Size (bits) | Approximate Range             | Precision     | Suffix    | Example               |
| --------- | ----------- | ----------------------------- | ------------- | --------- | --------------------- |
| `float`   | 32          | ±1.5 × 10⁻⁴⁵ to ±3.4 × 10³⁸   | ~7 digits     | `f`       | `float f = 3.14f;`    |
| `double`  | 64          | ±5.0 × 10⁻³²⁴ to ±1.7 × 10³⁰⁸ | ~15–16 digits | (default) | `double d = 3.14159;` |
| `decimal` | 128         | ±1.0 × 10⁻²⁸ to ±7.9 × 10²⁸   | ~28–29 digits | `m`       | `decimal m = 19.99m;` |


# String

-->string using double quotes -> string name =  " Jish " 
-->character using single quotes -> char letter =  's'
>> for character declaring and initializing is necessary, otherwise initialize with '\0'

# converting string to numbers
string textAge = "23";
int age = Convert.ToInt32(textAge);
Console.WriteLine(age);

# Boolean data type
-> true or false value
eg : bool isMale = true;

# operators 
    +   Addition            +=
    -   Subtraction         -=
    *   Multiplication      *=
    /   Division            /=
    %   Modulus (reminder)

    Pre-increment => ++age
    Post-increment => age++
    Pre-decrement => --age
    post-decrement => age--


# var keyword
var age =23;
var textage = "ten"

# const keyword
const int percentage = 5; -> unable to update

# odd/even check
using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n1=  10;
        int n2= 2;
        Console.WriteLine(n1%n2==0);
    }
}

# console input and output

using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter name"); //output
      string name = Console.ReadLine();  //input
      Console.WriteLine("Name is: "+name);
    }
}


