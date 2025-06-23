using System;

namespace Lab_4
{
    internal class Pro2
    {
        public double CalculateArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public double CalculateArea(double length, double width)
        {
            return length * width;
        }
    }
}
