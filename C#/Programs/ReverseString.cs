public class ReverseString
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string: ");
        string str = Console.ReadLine();
        string strAns = "";
        int end = str.Length-1;
        while ( end>=0)
        {
            strAns += str[end--];
        }
        Console.WriteLine("Reversed string is : " + strAns);
    }
}