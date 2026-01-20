using System;
class Program
{
    public static double MidPointRounding(double radius)
    {
        double area = Math.PI * radius*radius;
        return Math.Round(area, 2, MidpointRounding.AwayFromZero);
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());
        System.Console.WriteLine(MidPointRounding(radius));
    }
}
