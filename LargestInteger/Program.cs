using System;

class Program
{
    public static int LargestInteger(int a, int b, int c)
    {
        if(a>b && a > c)
        {
            return a;
        }else if(b>a && b > c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }

    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter Numbers: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(LargestInteger(a,b,c));
    }
}
