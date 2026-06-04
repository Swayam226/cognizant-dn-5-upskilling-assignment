using System;

class Program
{
    static (int Id, string Name) GetUser()
    {
        return (101, "Alice Johnson");
    }

    static void Main()
    {
        (int id, string name) = GetUser();
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Name: " + name);

        var result = GetUser();
        Console.WriteLine("Tuple .Id: " + result.Id);
        Console.WriteLine("Tuple .Name: " + result.Name);
    }
}
