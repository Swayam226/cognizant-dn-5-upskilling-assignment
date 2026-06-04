using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
        fruits.Add("Date");
        fruits.Add("Elderberry");

        Console.WriteLine("List<string> contents:");
        foreach (string fruit in fruits)
            Console.WriteLine("  " + fruit);

        fruits.Remove("Banana");
        Console.WriteLine("\nAfter removing 'Banana':");
        foreach (string fruit in fruits)
            Console.WriteLine("  " + fruit);

        Dictionary<int, string> employees = new Dictionary<int, string>
        {
            { 1, "Alice" },
            { 2, "Bob" },
            { 3, "Charlie" }
        };
        employees.Add(4, "Diana");

        Console.WriteLine("\nDictionary<int, string> contents:");
        foreach (KeyValuePair<int, string> entry in employees)
            Console.WriteLine("  ID: " + entry.Key + ", Name: " + entry.Value);

        employees.Remove(2);
        Console.WriteLine("\nAfter removing key 2:");
        foreach (KeyValuePair<int, string> entry in employees)
            Console.WriteLine("  ID: " + entry.Key + ", Name: " + entry.Value);
    }
}
