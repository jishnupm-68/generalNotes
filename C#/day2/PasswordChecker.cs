using System;
public class PasswordChecker
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("enter the password ");
        string password = Console.ReadLine();
        System.Console.WriteLine("Enter the password again");
        string rePassword = Console.ReadLine();
        if (password.Equals(rePassword)) System.Console.WriteLine("Password match");
        else System.Console.WriteLine("Password wrong");
    }
}