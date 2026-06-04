using System;
using System.Threading.Tasks;

class Program
{
    static async Task<string> SimulateFileUploadAsync(string fileName)
    {
        await Task.Delay(3000);
        if (string.IsNullOrEmpty(fileName))
            throw new ArgumentException("File name cannot be empty.");
        return "Upload successful: " + fileName;
    }

    static async Task Main()
    {
        Console.WriteLine("Starting file upload...");

        try
        {
            string result = await SimulateFileUploadAsync("report.pdf");
            Console.WriteLine(result);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }

        Console.WriteLine("\nTesting with empty file name:");
        try
        {
            string result = await SimulateFileUploadAsync("");
            Console.WriteLine(result);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
