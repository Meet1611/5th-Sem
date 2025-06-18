using System;

public interface Shape
{   
    double AreaOfCircle(int  radius);
    int AreaOfTriangle(int b, int h);
    int AreaOfSquare(int a);
}

class AreaCalculator : Shape
{
    public double AreaOfCircle(int radius)
    {
        return Math.PI * radius * radius;
    }
    public int AreaOfTriangle(int baseLength, int height)
    {
        return (baseLength * height) / 2;
    }
    public int AreaOfSquare(int sideLength)
    {
        return sideLength * sideLength;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        AreaCalculator calculator = new AreaCalculator();

        Console.WriteLine("Choose shape to calculate area: 1 for Circle, 2 for Triangle, 3 for Square");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("Enter radius of the circle:");
            int radius = int.Parse(Console.ReadLine());
            double area = calculator.AreaOfCircle(radius);

            Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter base length of the triangle:");
            int baseLength = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter height of the triangle:");
            int height = int.Parse(Console.ReadLine());

            int area = calculator.AreaOfTriangle(baseLength, height);
            Console.WriteLine($"The area of the triangle with base {baseLength} and height {height} is: {area}");
        }
        else if (choice == 3)
        {
            Console.WriteLine("Enter side length of the square:");
            int sideLength = int.Parse(Console.ReadLine());

            int area = calculator.AreaOfSquare(sideLength);
            Console.WriteLine($"The area of the square with side length {sideLength} is: {area}");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
        }
    }
}