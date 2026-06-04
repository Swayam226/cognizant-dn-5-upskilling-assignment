using System;
using System.IO;
using System.Text.Json;

class User
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        User user = new User
        {
            Name = "Alice Johnson",
            Age = 30,
            Email = "alice@example.com"
        };

        string jsonString = JsonSerializer.Serialize(user, new JsonSerializerOptions { WriteIndented = true });
        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(jsonString);

        string filePath = "user.json";
        File.WriteAllText(filePath, jsonString);
        Console.WriteLine("\nJSON saved to " + filePath);

        string jsonFromFile = File.ReadAllText(filePath);
        User deserializedUser = JsonSerializer.Deserialize<User>(jsonFromFile);

        Console.WriteLine("\nDeserialized User:");
        Console.WriteLine("Name: " + deserializedUser.Name);
        Console.WriteLine("Age: " + deserializedUser.Age);
        Console.WriteLine("Email: " + deserializedUser.Email);
    }
}
