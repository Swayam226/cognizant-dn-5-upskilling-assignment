using System;
using System.Collections.Generic;

class Contact
{
    public string? Name { get; set; }
    public string? PhoneNumber { get; set; }
}

class Program
{
    static void Main()
    {
        List<Contact?> contacts = new List<Contact?>
        {
            new Contact { Name = "Alice Johnson", PhoneNumber = "555-1234" },
            new Contact { Name = null, PhoneNumber = "555-5678" },
            null,
            new Contact { Name = "Bob Smith", PhoneNumber = null }
        };

        foreach (var contact in contacts)
        {
            string? name = contact?.Name;
            string? phone = contact?.PhoneNumber;

            if (contact?.Name != null)
                Console.WriteLine("Name: " + name + ", Phone: " + (phone ?? "N/A"));
            else
                Console.WriteLine("Contact or name is unavailable.");
        }
    }
}
