using System;

class Program
{
    static long CalculateFactorial(int n)
    {
        long LocalFactorial(int x)
        {
            if (x <= 1) return 1;
            return x * LocalFactorial(x - 1);
        }

        return LocalFactorial(n);
    }

    static void Main()
    {
        Console.WriteLine("Factorial of 5: " + CalculateFactorial(5));
        Console.WriteLine("Factorial of 7: " + CalculateFactorial(7));
        Console.WriteLine("Factorial of 10: " + CalculateFactorial(10));
    }
}
