using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your score: ");
        int score = int.Parse(Console.ReadLine());

        string gradeIfElse;

        if (score >= 90)
            gradeIfElse = "A";
        else if (score >= 80)
            gradeIfElse = "B";
        else if (score >= 70)
            gradeIfElse = "C";
        else if (score >= 60)
            gradeIfElse = "D";
        else
            gradeIfElse = "F";

        Console.WriteLine("Grade (if-else): " + gradeIfElse);

        string gradeSwitch = score switch
        {
            >= 90 => "A",
            >= 80 => "B",
            >= 70 => "C",
            >= 60 => "D",
            _ => "F"
        };

        Console.WriteLine("Grade (switch pattern matching): " + gradeSwitch);
    }
}
