using System;

class SimpleInterestCalculator
{
    static double CalculateInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }

    static void Main()
    {
        Console.Write("Enter Principal: ");
        double p = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Rate: ");
        double r = double.Parse(Console.ReadLine());
        
        Console.Write("Enter Time: ");
        double t = double.Parse(Console.ReadLine());

        Console.WriteLine("Simple Interest = " + CalculateInterest(p, r, t));
    }
}