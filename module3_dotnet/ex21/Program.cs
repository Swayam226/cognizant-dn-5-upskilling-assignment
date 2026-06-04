using System;

class Animal
{
    public string Name { get; set; }
    public Animal(string name) { Name = name; }
}

class Dog : Animal
{
    public Dog(string name) : base(name) { }
}

class Cat : Animal
{
    public Cat(string name) : base(name) { }
}

class Program
{
    static void DescribeObject(object obj)
    {
        if (obj is int i)
            Console.WriteLine("Integer: " + i);
        else if (obj is string s)
            Console.WriteLine("String of length " + s.Length + ": " + s);
        else if (obj is Dog d)
            Console.WriteLine("Dog named: " + d.Name);
        else if (obj is Cat c)
            Console.WriteLine("Cat named: " + c.Name);
        else
            Console.WriteLine("Unknown type: " + obj.GetType().Name);
    }

    static void SwitchDescribe(object obj)
    {
        switch (obj)
        {
            case int n when n > 100:
                Console.WriteLine("Large integer: " + n);
                break;
            case int n:
                Console.WriteLine("Small integer: " + n);
                break;
            case string str:
                Console.WriteLine("String value: " + str);
                break;
            case Dog dog:
                Console.WriteLine("Switch - Dog: " + dog.Name);
                break;
            case Cat cat:
                Console.WriteLine("Switch - Cat: " + cat.Name);
                break;
            default:
                Console.WriteLine("Switch - Unknown type");
                break;
        }
    }

    static void Main()
    {
        object[] objects = { 42, 200, "Hello", new Dog("Rex"), new Cat("Whiskers") };

        Console.WriteLine("Using is pattern matching:");
        foreach (var obj in objects)
            DescribeObject(obj);

        Console.WriteLine("\nUsing switch pattern matching:");
        foreach (var obj in objects)
            SwitchDescribe(obj);
    }
}
