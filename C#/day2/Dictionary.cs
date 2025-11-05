using System.Collections.Generic;
class Program

{
    static void Main(string[] args)
    {
        Dictionary<int, string> names = new Dictionary<int, string>();
        names.Add(0, "Jishnu");
        for(int i = 0; i < names.Count; i++)
        {
            System.Console.WriteLine(names[i]);
            KeyValuePair<int,string> item = names.ElementAt(i);
            System.Console.WriteLine(item);
        }
    }
}