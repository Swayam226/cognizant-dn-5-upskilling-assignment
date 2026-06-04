using System;

class Person
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public Address? HomeAddress { get; set; }
}

class Address
{
    public string? City { get; set; }
    public string? Country { get; set; }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person
        {
            Name = "Alice",
            Email = "alice@example.com",
            HomeAddress = new Address { City = "New York", Country = "USA" }
        };

        Person person2 = new Person();

        Console.WriteLine("Person 1:");
        Console.WriteLine("Name: " + (person1.Name ?? "N/A"));
        Console.WriteLine("Email: " + (person1.Email ?? "N/A"));
        Console.WriteLine("City: " + (person1.HomeAddress?.City ?? "N/A"));
        Console.WriteLine("Country: " + (person1.HomeAddress?.Country ?? "N/A"));

        Console.WriteLine("\nPerson 2 (null properties):");
        Console.WriteLine("Name: " + (person2.Name ?? "N/A"));
        Console.WriteLine("Email: " + (person2.Email ?? "N/A"));
        Console.WriteLine("City: " + (person2.HomeAddress?.City ?? "N/A"));
        Console.WriteLine("Country: " + (person2.HomeAddress?.Country ?? "N/A"));

        if (person1.Name is not null)
            Console.WriteLine("\nPerson 1 name length: " + person1.Name.Length);

        if (person2.Name is null)
            Console.WriteLine("Person 2 name is null.");
    }
}
