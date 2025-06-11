using System;

class pro10
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        
        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        int max = (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);

        Console.WriteLine("Maximum number is: " + max);
    }
}