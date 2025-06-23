using System;

namespace Lab_4
{
    internal class Square
    {
        public double CalculateArea(double side)
        {
            return side * side;
        }
    }

    class Rectangle
    {
        public double CalculateArea(double length, double width)
        {
            return length * width;
        }
    }

    class Circle
    {
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}

