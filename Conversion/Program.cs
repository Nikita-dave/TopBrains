using System;
class Program
{
    public static double Conversion(int feet)
    {
        double centimeters = 30.48*feet;
        return Math.Round(centimeters, 2, MidpointRounding.AwayFromZero);
    }

    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter value in Feet: ");
        int feet = int.Parse(Console.ReadLine());
        System.Console.WriteLine(Conversion(feet));
    }
}
