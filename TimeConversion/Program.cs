using System;
class Program
{
    public static string TimeConversion(int totalSeconds)
    {
        int minutes = totalSeconds/60;
        int seconds = totalSeconds%60;

        return minutes+":"+seconds.ToString("D2");
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter time: ");
        int totalSeconds = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine(TimeConversion(totalSeconds));
    }
}
