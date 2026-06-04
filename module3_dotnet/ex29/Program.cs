using System;
using System.Net;

class Program
{
    static string SanitizeInput(string input)
    {
        return WebUtility.HtmlEncode(input);
    }

    static void SimulateFormDisplay(string userInput)
    {
        Console.WriteLine("Raw input:       " + userInput);
        string sanitized = SanitizeInput(userInput);
        Console.WriteLine("Sanitized input: " + sanitized);
    }

    static void Main()
    {
        string[] testInputs =
        {
            "Hello, World!",
            "<script>alert('XSS Attack!')</script>",
            "<img src=x onerror=alert('hack')>",
            "Normal user input with <b>bold</b> tags",
            "'; DROP TABLE Users; --"
        };

        foreach (string input in testInputs)
        {
            Console.WriteLine("---");
            SimulateFormDisplay(input);
        }
    }
}
