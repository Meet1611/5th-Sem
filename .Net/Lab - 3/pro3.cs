using System;

public abstract class Sum
{
    public abstract int SumOfTwo(int a, int b);
    public abstract int SumOfThree(int a, int b, int c);
}

class Calculate : Sum
{
    public override int SumOfTwo(int a, int b)
    {
        return a + b;
    }
    public override int SumOfThree(int a, int b, int c)
    {
        return a + b + c;
    }
}

class Program
{
    public static void Main()
    {
        Calculate c = new Calculate();
        Console.WriteLine("Sum of 2 numbers: " + c.SumOfTwo(10, 20));
        Console.WriteLine("Sum of 3 numbers: " + c.SumOfThree(10, 20, 30));
    }
}