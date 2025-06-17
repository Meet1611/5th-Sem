using System;

class Distance
{
    private double dist1, dist2, dist3;

    // Constructor to initialize dist1 and dist2
    public Distance(double d1, double d2)
    {
        dist1 = d1;
        dist2 = d2;
        dist3 = 0;
    }

    // Function to add distances
    public void AddDistances()
    {
        dist3 = dist1 + dist2;
    }

    public void Display()
    {
        Console.WriteLine("\n--- Distance Addition ---");
        Console.WriteLine("Distance 1: " + dist1);
        Console.WriteLine("Distance 2: " + dist2);
        Console.WriteLine("Total Distance: " + dist3);
    }

    public static void Main()
    {
        Distance d = new Distance(12.5, 7.8);
        d.AddDistances();
        d.Display();
    }
}
