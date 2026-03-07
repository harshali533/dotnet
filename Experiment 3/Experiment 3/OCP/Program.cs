using System;

abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double Radius;

    public override double Area()
    {
        return 3.14 * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Length;
    public double Width;

    public override double Area()
    {
        return Length * Width;
    }
}

class Program
{
    static void Main()
    {
        Shape s = new Circle();
        ((Circle)s).Radius = 5;

        Console.WriteLine("Area: " + s.Area());
    }
}