using System;

namespace Classes
{
    class classesOOps
    {
        public void greeting()
        {
            System.Console.WriteLine("heiiiii");
        }
    }
    class Temp
    {
        static void Main(string[] args)
        {
            classesOOps co = new classesOOps();
            co.greeting();
        }
    }
}