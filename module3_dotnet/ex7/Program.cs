using System;

class Program
{
    static int CalculateTotal(int a, int b)
    {
        return a + b;
    }

    static double CalculateTotal(double a, double b, double c)
    {
        return a + b + c;
    }

    static double CalculateTotal(int a, double b)
    {
        return a + b;
    }

    static double CalculateTotal(double a, double b)
    {
        return a + b;
    }

    static void Main()
    {
        Console.WriteLine("CalculateTotal(3, 5): " + CalculateTotal(3, 5));
        Console.WriteLine("CalculateTotal(1.5, 2.5, 3.0): " + CalculateTotal(1.5, 2.5, 3.0));
        Console.WriteLine("CalculateTotal(4, 2.75): " + CalculateTotal(4, 2.75));
        Console.WriteLine("CalculateTotal(1.1, 2.2): " + CalculateTotal(1.1, 2.2));
    }
}
