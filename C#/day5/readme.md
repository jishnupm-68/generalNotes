# reference: https://learn.microsoft.com/en-us/training/modules/csharp-call-methods/1-introduction


> Stateful vs stateless methods

Some methods don't rely on the current state of the application to work properly. In other words, stateless methods are implemented so that they can work without referencing or changing any values already stored in memory. Stateless methods are also known as static methods.
eg: the Console.WriteLine() method doesn't rely on any values stored in memory. It performs its function and finishes without impacting the state of the application in any way.

stateful methods are built in such a way that they rely on values stored in memory by previous lines of code that have already been executed. Or they modify the state of the application by updating values or storing new values in memory. They're also known as instance methods.


> instance of a  class is called object