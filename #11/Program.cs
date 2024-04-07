using System;

public interface IScalable
{
    void Scale(double s);
}

public class Circle : IScalable
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public void Scale(double s)
    {
        Radius *= s;
    }

    public override string ToString()
    {
        return $"Коло з радiусом {Radius}";
    }
}

public class Rectangle : IScalable
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public void Scale(double s)
    {
        Width *= s;
        Height *= s;
    }

    public override string ToString()
    {
        return $"Прямокутник з шириною {Width} та висотою {Height}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circle circle = new Circle(5);
        Rectangle rectangle = new Rectangle(4, 3);

        Console.WriteLine("Початковий:");
        Console.WriteLine(circle);
        Console.WriteLine(rectangle);

        circle.Scale(10);
        rectangle.Scale(20);

        Console.WriteLine("\nПiсля масштабування:");
        Console.WriteLine(circle);
        Console.WriteLine(rectangle);
    }
}