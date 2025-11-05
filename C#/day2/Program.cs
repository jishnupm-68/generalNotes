using System;
public class Hello{
    public static void Main(string [] args){
        int limit =2;
        for(int i=1;i<=10;i++) Console.WriteLine("{0} x {1} = {2}",i, limit, i*limit);
    }
}