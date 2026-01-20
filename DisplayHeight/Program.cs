using System;
class Program
{
    public static string DisplayHeight(int height)
    {
        if(height < 150)
        {
            return "Short";
        }
        else if(height>=150 && height<180)
        {
            return "Average";
        }
        else
        {
            return "Tall";
        }
    }

    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter height (0 to 300):");
        int height = int.Parse(Console.ReadLine());
        System.Console.WriteLine(DisplayHeight(height));
    }
}
