class Program
{
    public static void Main(string[] args)
    {
        int n;
        string d;
        test(6,45, out n, out d);
        System.Console.WriteLine(n + " " + d);
        int number = 43;
        System.Console.WriteLine("before calling function {0}", number);
        // System.Console.WriteLine(referFun(ref number));
        referFun(ref number);
        System.Console.WriteLine("after calling function {0}", number);
       
    }

    static void test(int a, int b, out int num, out string data)
    {
        num = a + b;
        data = "jishnu";
    }
    static void referFun(ref int num)
    {
        num *= 10;
    }
}