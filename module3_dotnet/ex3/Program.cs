using System;

class Person(string firstName, string lastName, int age)
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public int Age { get; } = age;

    public void DisplayInfo()
    {
        Console.WriteLine("Full Name: " + FirstName + " " + LastName);
        Console.WriteLine("Age: " + Age);
    }
}

class Program
{
    static void Main()
    {
        Person person = new Person("John", "Doe", 30);
        Console.WriteLine("First Name: " + person.FirstName);
        Console.WriteLine("Last Name: " + person.LastName);
        Console.WriteLine("Age: " + person.Age);
        Console.WriteLine();
        person.DisplayInfo();
    }
}
