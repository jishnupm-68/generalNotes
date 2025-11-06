class TriangleArea
{
    public static void Main(string[] args)
    {
        int height = ReadData("Enter height");
        int width = ReadData("Enter width");
        float area = Trianglearea(height, width);
        System.Console.WriteLine("area : {0}", area);

    }


    static int ReadData(string message)
    {
        System.Console.WriteLine(message);
        return Convert.ToInt32(Console.ReadLine());
    }
    
    static float Trianglearea(int h, int w)
    {
        float area = (h * w) / 2;
        return area;
    }
}