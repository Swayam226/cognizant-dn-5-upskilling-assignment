using System;

class SampleClass
{
    public string Label { get; set; }
    public SampleClass(string label) { Label = label; }
    public override string ToString() => "SampleClass(Label=" + Label + ")";
}

class Program
{
    static void Main()
    {
        var number = 42;
        Console.WriteLine("Value: " + number + ", Type: " + number.GetType().Name);

        var text = "Hello, C#";
        Console.WriteLine("Value: " + text + ", Type: " + text.GetType().Name);

        var pi = 3.14159;
        Console.WriteLine("Value: " + pi + ", Type: " + pi.GetType().Name);

        var flag = true;
        Console.WriteLine("Value: " + flag + ", Type: " + flag.GetType().Name);

        SampleClass obj = new("TypeInference");
        Console.WriteLine("Value: " + obj + ", Type: " + obj.GetType().Name);

        var obj2 = new SampleClass("VarWithNew");
        Console.WriteLine("Value: " + obj2 + ", Type: " + obj2.GetType().Name);
    }
}
