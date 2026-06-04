using System;

record Employee
{
    public required string Name { get; init; }
    public required string Department { get; init; }
    public required double Salary { get; init; }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new Employee
        {
            Name = "Alice Johnson",
            Department = "Engineering",
            Salary = 85000
        };

        Console.WriteLine("Original Employee:");
        Console.WriteLine("Name: " + emp1.Name);
        Console.WriteLine("Department: " + emp1.Department);
        Console.WriteLine("Salary: " + emp1.Salary);

        Employee emp2 = emp1 with { Department = "Management", Salary = 95000 };

        Console.WriteLine("\nModified Copy (with expression):");
        Console.WriteLine("Name: " + emp2.Name);
        Console.WriteLine("Department: " + emp2.Department);
        Console.WriteLine("Salary: " + emp2.Salary);

        Console.WriteLine("\nOriginal Unchanged:");
        Console.WriteLine("Name: " + emp1.Name);
        Console.WriteLine("Department: " + emp1.Department);
        Console.WriteLine("Salary: " + emp1.Salary);
    }
}
