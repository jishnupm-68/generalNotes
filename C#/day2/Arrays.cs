using System;
using System.Runtime.ConstrainedExecution;
namespace Arrays
{
    class Arrays
    {
        public static void Main(string[] args)
        {
            // int[] nums = new int[3];
            // System.Console.WriteLine(nums);
            // nums[0] = 1;
            // nums[2] = 4;

            // // System.Console.WriteLine(nums[0]);
            // for (int i = 0; i < nums.Length; i++) System.Console.WriteLine(nums[i]);

            // foreach(int item in nums)System.Console.WriteLine("using foreach "+ item);

            // int[] angles = new int[3];
            // for (int i = 0; i < 3; i++)
            // {
            //     System.Console.WriteLine("Enter angle "+ i);
            //     angles[i] = Convert.ToInt32(Console.ReadLine());
            // }
            // int totalAngle = 0;
            // foreach (int angle in angles)
            // {
            //     System.Console.WriteLine("Angle " + angle);
            //     totalAngle += angle;
            // }
            // System.Console.WriteLine($"total angle {totalAngle}");
            // int[] nums = new int[9];
            // for (int i = 0; i < 9; i++)
            // {
            //     System.Console.WriteLine("enter number " + i);
            //     nums[i] = Convert.ToInt32(Console.ReadLine());

            // }
            // foreach (int num in nums) System.Console.Write(num + " ");
            // System.Console.WriteLine();
            // Array.Sort(nums);
            // foreach (int num in nums) System.Console.Write(num + " ");
            // int[] numbers = new int[]
            // {
            //     2,43,3,2,5643,342
            // };
            // Array.Clear(numbers, 2, 2);
            // System.Console.WriteLine(Array.IndexOf(numbers, 5644353));
            // foreach (int num in numbers) System.Console.Write(num + " ");

            // array of multiples
            System.Console.WriteLine("enter num: ");
            int num = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("enter length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = (i + 1) * num;
            }

            for (int i =0 ; i < length; i++)
            {
                System.Console.Write(array[i]+ " ");
            }
            

        } 
    }
}