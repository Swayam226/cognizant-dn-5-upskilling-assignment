using System;

class Student
{
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required int StudentId { get; init; }
    public string? Email { get; init; }

    public void Display()
    {
        Console.WriteLine("Student ID: " + StudentId);
        Console.WriteLine("Name: " + FirstName + " " + LastName);
        Console.WriteLine("Email: " + (Email ?? "N/A"));
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student
        {
            FirstName = "Jane",
            LastName = "Doe",
            StudentId = 1001,
            Email = "jane.doe@example.com"
        };

        student.Display();
    }
}
