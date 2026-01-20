using System;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * radius*radius;
        Console.WriteLine("Area: {0:F2}",area);
    }
}
