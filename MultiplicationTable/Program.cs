using System;
class Program{
   public static int[] MultiplicationTable(int n, int upto)
    {
        int[] result = new int[upto];
        for(int i = 1; i <= upto; i++)
        {
            result[i-1] = n*i;
        }  
        return result;
    }
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int upto = Convert.ToInt32(Console.ReadLine());

        int[] result = MultiplicationTable(n, upto);

        foreach (int item in result)
        {
            System.Console.Write(item+" ");
        }
    } 
}