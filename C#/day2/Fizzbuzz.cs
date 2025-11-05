using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 15;
            for(int i=1; i<=num; i++) {
                if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("fizzbuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else
                {
                    Thread.Sleep(400);
                    Console.WriteLine(i);
                }
                }
        }
    }
}
