using System;

class Program
{
    static string Evaluate(string expression)
    {
        string[] parts = expression.Split(' ');

        // Check format
        if (parts.Length != 3)
            return "Error:InvalidExpression";

        int a, b;

        // Convert numbers
        try
        {
            a = Convert.ToInt32(parts[0]);
            b = Convert.ToInt32(parts[2]);
        }
        catch
        {
            return "Error:InvalidNumber";
        }

        string op = parts[1];

        if (op == "+")
            return (a + b).ToString();
        if (op == "-")
            return (a - b).ToString();
        if (op == "*")
            return (a * b).ToString();
        if (op == "/")
        {
            if (b == 0)
                return "Error:DivideByZero";
            return (a / b).ToString();
        }

        return "Error:UnknownOperator";
    }

    static void Main()
    {
        Console.WriteLine(Evaluate("10 + 5"));
        Console.WriteLine(Evaluate("10 / 0"));
        Console.WriteLine(Evaluate("a + 5"));
        Console.WriteLine(Evaluate("10 ^ 5"));
        Console.WriteLine(Evaluate("10+5"));
    }
}
