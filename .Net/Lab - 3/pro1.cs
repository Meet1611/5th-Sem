using System;

public class Program
{
    static double divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        else
        {
            return ((double)a / b);
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter first number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number : ");
        int b = Convert.ToInt32(Console.ReadLine());

        try
        {
            double ans = divide(a, b);
        }
        catch(DivideByZeroException e)         {
            Console.WriteLine(e.Message);
        }
    }
}