using System;

class Program
{
    public static int SumofPositiveintegers(int[] arr)
    {
        int sum=0;
        if (arr.Length == 0)
        {
            return 0;
        }
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                continue;
            }
            if (arr[i] == 0)
            {
                break;
            }
            sum += arr[i];
        }
        return sum;
    }

    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for(int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        System.Console.WriteLine(SumofPositiveintegers(arr));
    }
}
