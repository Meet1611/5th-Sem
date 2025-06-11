using System;

class pro9
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
       
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Before swap: a = {a}, b = {b}");

        a = a + b;
        b = a - b;
        a = a - b;

        Console.WriteLine($"After swap: a = {a}, b = {b}");
    }
}