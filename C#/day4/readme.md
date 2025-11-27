
# Reference: https://learn.microsoft.com/en-us/training/modules/csharp-write-first/1-introduction

> Compilation: A special program called a compiler converts your source code into a different format that the computer's central processing unit (CPU) can execute
> syntax  : Rules to write C# code

        . (dot / period operator) => member access operator
        () / parantheses after method name =>  method invocation operator



# Reference: https://learn.microsoft.com/en-us/training/modules/csharp-literals-variables/1-introduction

>  hard-coded value can also be called a constant, or a literal value.

Data types
> Character literals : char keyword used , use single quote and it contains only one character
> String literals: string keyword used, use double quote and it contains multiple characters
> Integer literals : int keyword used 
> Floating point literals : 3 types are used
Float Type    Precision            Suffix used
------------------------------------------------
float         ~6-9 digits              F/f  
double        ~15-17 digits
decimal        28-29 digits            M/m  

> Boolean literals: bool keyword used , true or false values are accepted

Declare variable
> A variable is a container for storing a type of value.
> Assigning a value is also referred to as "setting the variable", or simply, a "set" operation.
> Retrieving a value from a variable is also referred to as "getting the variable", or simply, a "get" operation.
> Assignment happens from right to left

Variable name rules and conventions
> Variable names can contain alphanumeric characters and the underscore character. Special characters like the hash symbol # (also known as the number symbol or pound symbol) or dollar symbol $ are not allowed.
> Variable names must begin with an alphabetical letter or an underscore, not a number.
> Variable names are case-sensitive, meaning that string Value; and string value; are two different variables.
> Variable names must not be a C# keyword. For example, you cannot use the following variable declarations: decimal decimal; or string string;.
> Variable names should use camel case, which is a style of writing that uses a lower-case letter at the beginning of the first word and an upper-case letter at the beginning of each subsequent word.eg: string thisIsCamelCase;.
> Variable names shouldn't include the data type of the variable. You might see some advice to use a style like string strValue;. That advice is no longer current


Declare implicitly typed local variables
An implicitly typed local variable is created by using the var keyword followed by a variable initialization.


# Reference: https://learn.microsoft.com/en-us/training/modules/csharp-basic-formatting/1-introduction

Character escape sequences
> An escape character sequence is an instruction to the runtime to insert a special character that will affect the output of your string. eg: the \n sequence will add a new line, and a \t sequence will add a tab.

Verbatim string literal
> A verbatim string literal will keep all whitespace and characters without the need to escape the backslash. To create a verbatim string, use the @ directive before the literal string.

> Use the \u plus a four-character code to represent Unicode characters (UTF-16) in a string.
> interpolation expression is indicated by an opening and closing curly brace symbol { }. You can put any C# expression that returns a value inside the braces. The literal string becomes a template when it's prefixed by the $ character.


# Reference : https://learn.microsoft.com/en-us/training/modules/csharp-basic-operations/1-introduction

> Operators like +=, -=, *=, ++, and -- are known as compound assignment operators because they compound some operation in addition to assigning the result to the variable. 