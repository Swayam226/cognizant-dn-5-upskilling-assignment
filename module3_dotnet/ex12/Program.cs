using System;

class Product
{
    public string Name { get; set; }

    private double _price;
    public double Price
    {
        get { return _price; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Invalid: Price cannot be negative. Price unchanged.");
            }
            else
            {
                _price = value;
            }
        }
    }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name + ", Price: " + Price);
    }
}

class Program
{
    static void Main()
    {
        Product p = new Product("Laptop", 999.99);
        p.Display();

        p.Price = 1199.99;
        Console.WriteLine("After valid update:");
        p.Display();

        p.Price = -50;
        Console.WriteLine("After invalid update:");
        p.Display();
    }
}
