using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "sample.txt";
        File.WriteAllText(filePath, "Hello from FileStream!\nThis is line two.");

        Console.WriteLine("Reading file using FileStream:");
        using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            string content = Encoding.UTF8.GetString(buffer);
            Console.WriteLine(content);
        }

        string data = "Hello from MemoryStream! Writing some bytes.";
        byte[] dataBytes = Encoding.UTF8.GetBytes(data);

        Console.WriteLine("\nWriting to MemoryStream:");
        using (MemoryStream ms = new MemoryStream())
        {
            ms.Write(dataBytes, 0, dataBytes.Length);
            Console.WriteLine("Bytes written: " + ms.Length);

            ms.Position = 0;
            using (StreamReader reader = new StreamReader(ms))
            {
                string result = reader.ReadToEnd();
                Console.WriteLine("Content read back: " + result);
            }
        }
    }
}
