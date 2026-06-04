using System;

class BaseClass
{
    public string PublicField = "I am public";
    private string privateField = "I am private";
    protected string ProtectedField = "I am protected";

    public void ShowPrivate()
    {
        Console.WriteLine(privateField);
    }
}

class DerivedClass : BaseClass
{
    public void ShowMembers()
    {
        Console.WriteLine("From DerivedClass:");
        Console.WriteLine("Public: " + PublicField);
        Console.WriteLine("Protected: " + ProtectedField);
    }
}

class Program
{
    static void Main()
    {
        BaseClass baseObj = new BaseClass();
        Console.WriteLine("From non-derived class:");
        Console.WriteLine("Public: " + baseObj.PublicField);
        baseObj.ShowPrivate();

        DerivedClass derivedObj = new DerivedClass();
        derivedObj.ShowMembers();
    }
}
