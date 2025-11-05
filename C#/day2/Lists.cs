using System;
namespace Lists
{
    public class Lists
    {
        public static void Main(String[] args)
        {
            // List<int> listNumbers = new List<int>()
            // {
            //     1, 2, 34, 567, 87
            // };
            // System.Console.WriteLine(listNumbers);
            // List<int> newList = new List<int>();
            // for (int i = 0; i < 5; i++)
            // {
            //     newList.Add(Convert.ToInt32(Console.ReadLine()));
            // }

            // for (int i = 0; i < newList.Count; i++)
            // {
            //    System.Console.Write(newList[i]+ " ");
            // }

            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();

            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0) evenList.Add(i);
                else oddList.Add(i);
            }

            System.Console.WriteLine("oddList");
            foreach (int item in oddList) System.Console.Write(item + " ");
            System.Console.WriteLine();
            System.Console.WriteLine("evenList");
            foreach(int item in evenList)System.Console.Write(item + " ");
            
        }
    }
}