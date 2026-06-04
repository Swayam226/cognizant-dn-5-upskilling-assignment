using System;

class PersonRef
{
    public string Name { get; set; }
    public PersonRef(string name) { Name = name; }
}

class Program
{
    static void ModifyValue(int x)
    {
        x = 100;
    }

    static void ModifyDouble(double d)
    {
        d = 9.99;
    }

    static void ModifyString(string s)
    {
        s = "Modified";
    }

    static void ModifyPerson(PersonRef p)
    {
        p.Name = "Modified Name";
    }

    static void Main()
    {
        int num = 10;
        Console.WriteLine("Before ModifyValue: " + num);
        ModifyValue(num);
        Console.WriteLine("After ModifyValue: " + num);

        double price = 3.14;
        Console.WriteLine("Before ModifyDouble: " + price);
        ModifyDouble(price);
        Console.WriteLine("After ModifyDouble: " + price);

        string text = "Hello";
        Console.WriteLine("Before ModifyString: " + text);
        ModifyString(text);
        Console.WriteLine("After ModifyString: " + text);

        PersonRef person = new PersonRef("Alice");
        Console.WriteLine("Before ModifyPerson: " + person.Name);
        ModifyPerson(person);
        Console.WriteLine("After ModifyPerson: " + person.Name);
    }
}
