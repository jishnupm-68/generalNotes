using System;
class ExceptionHandle
{
    public static void Main(string[] args)
    {
        int num = default;
        // try
        // {
        //     Console.WriteLine("enter number ");
        //     num = Convert.ToInt32(Console.ReadLine());
        // }
        // catch (FormatException)
        // {
        //     System.Console.WriteLine("Error : FormatException");
        // }

        // catch (OverflowException)
        // {
        //     System.Console.WriteLine("Error : OverFlowException");
        // }

        // catch (Exception e)
        // {
        //     Console.WriteLine("Error: something {0}", e.Message);
        //     num = 5;
        // }
        bool success = false;
        while (!success)
        {
         try   
        {
            Console.WriteLine("Enter number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            success = true;
        }
        catch (Exception e)
        {
            System.Console.WriteLine("Error: "+ e.Message);
        }

        }

        Console.WriteLine("the end {0} ", success ? "Value accepted" : "Value rejected");
    }
}

