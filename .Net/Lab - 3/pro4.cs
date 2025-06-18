using System;

interface Calculate
{
    int Addition(int a, int b);
    int Subtraction(int a, int b);
}

class Result : Calculate
{
    public int Addition(int a, int b)
    {
        return a + b;
    }

    public int Subtraction(int a, int b)
    {
        return a - b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Result r = new Result();
        Console.WriteLine("Enter first number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second number : ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition : " + r.Addition(a, b));
        Console.WriteLine("Addition : " + r.Subtraction(a, b));
    }
}