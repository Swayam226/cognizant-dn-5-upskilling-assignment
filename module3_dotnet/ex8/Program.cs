using System;

class Program
{
    static void UseRef(ref int value)
    {
        value *= 2;
    }

    static void UseOut(out int result)
    {
        result = 99;
    }

    static void UseIn(in int value)
    {
        Console.WriteLine("Inside UseIn, value: " + value);
    }

    static void Main()
    {
        int refValue = 10;
        Console.WriteLine("Before ref: " + refValue);
        UseRef(ref refValue);
        Console.WriteLine("After ref: " + refValue);

        int outValue;
        UseOut(out outValue);
        Console.WriteLine("After out: " + outValue);

        int inValue = 50;
        Console.WriteLine("Before in: " + inValue);
        UseIn(in inValue);
        Console.WriteLine("After in: " + inValue);
    }
}
