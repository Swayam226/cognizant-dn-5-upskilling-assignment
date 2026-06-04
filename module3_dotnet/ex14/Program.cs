using System;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle.");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Rectangle.");
    }
}

class Program
{
    static void Main()
    {
        Shape shape = new Shape();
        shape.Draw();

        Circle circle = new Circle();
        circle.Draw();

        Rectangle rectangle = new Rectangle();
        rectangle.Draw();

        Shape polyCircle = new Circle();
        polyCircle.Draw();

        Shape polyRect = new Rectangle();
        polyRect.Draw();
    }
}
