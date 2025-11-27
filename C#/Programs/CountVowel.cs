public class CountVowel
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the string ");
        string inputString = Console.ReadLine();
        string temp = "AEIOUaeiou";
        int length = inputString.Length-1;
        int count=0;
        while (length >= 0)
        {
            if(temp.Contains(inputString[length--])) count++;
        }
        System.Console.WriteLine("vowels in "+ inputString + " is : "+count);
    }
}