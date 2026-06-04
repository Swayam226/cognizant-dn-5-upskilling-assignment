using System;

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Car()
    {
        Make = "Unknown";
        Model = "Unknown";
        Year = 0;
    }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public void Display()
    {
        Console.WriteLine("Make: " + Make + ", Model: " + Model + ", Year: " + Year);
    }
}

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        Console.WriteLine("Car 1 (default constructor):");
        car1.Display();

        Car car2 = new Car("Toyota", "Camry", 2023);
        Console.WriteLine("Car 2 (parameterized constructor):");
        car2.Display();
    }
}
