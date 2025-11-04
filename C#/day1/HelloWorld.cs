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
            // hello world  
            Console.WriteLine("Hello world");
            Console.WriteLine();

            //accessing input 
            string name = Console.ReadLine();
            Console.WriteLine("The name is " + name);

            //Integer;
            int age = 32;
            long bigNumber = 23456534L;
            double negative = -2345.23D;
            float precesion = 5.34566f;
            decimal money = 234.243M;

            // strings
            string fullName = "Absdsdf";
            char letterInitial = "m";
            
        }
    }
}
