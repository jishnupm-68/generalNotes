using System;

namespace functions
{
    class Test
    {
        public static void test1()
        {
            System.Console.WriteLine("TEst1");
        }
        public void test2()
        {
            System.Console.WriteLine("test 2");
        }
    }
    public class Functions {
        public static void Main(String[] args)
        {
            Test.test1();
            System.Console.WriteLine("je;l;pp");
            welcome("jishnu");
            Test t = new Test();
            t.test2();

            System.Console.WriteLine(returnString());


        }

        static void welcome(string name)
        {
            System.Console.WriteLine("Welcome to my Program {0}", name);
        }
        static string returnString()
        {
            return "Helloooo";
        }
     }

}