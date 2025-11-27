using System;
public class  EvenOdd
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter  a number : ");
        int number= Convert.ToInt32(Console.ReadLine());
        string ans ="";
        if(number%2==0) ans= number+ " Is even";
        else ans = number + " is odd";
        System.Console.WriteLine(ans);
    }
    
}