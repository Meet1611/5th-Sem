using System;

class Rectangle
{
    double length;
    double width;

    public Rectangle(double length, double width)
    {
        this.width = width;
        this.length = length;
    }

    public double CalculateArea()
    {
        return length * width;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Length of Rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Width of Rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Rectangle rectangle = new Rectangle(length, width);
        double area = rectangle.CalculateArea();
        
        Console.WriteLine("Area of Rectangle: " + area);
    }
}