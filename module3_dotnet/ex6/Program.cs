using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 3, 5, 7, 9, 11, 13 };

        Console.WriteLine("for loop (skip value 7, stop at 11):");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == 7) continue;
            if (numbers[i] == 11) break;
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("foreach loop (skip odd index values):");
        int idx = 0;
        foreach (int n in numbers)
        {
            if (idx % 2 != 0) { idx++; continue; }
            Console.WriteLine(n);
            idx++;
        }

        Console.WriteLine("while loop (stop when value >= 9):");
        int i2 = 0;
        while (i2 < numbers.Length)
        {
            if (numbers[i2] >= 9) break;
            Console.WriteLine(numbers[i2]);
            i2++;
        }

        Console.WriteLine("do-while loop (skip value 5):");
        int i3 = 0;
        do
        {
            if (numbers[i3] == 5) { i3++; continue; }
            Console.WriteLine(numbers[i3]);
            i3++;
        } while (i3 < numbers.Length);
    }
}
