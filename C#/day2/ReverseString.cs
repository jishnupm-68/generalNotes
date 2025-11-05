using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
      string message = "hello world";
      int end = message.Length-1;
      for(int i=end;i>=0;i--)  Console.Write(message[i]);
    }
}