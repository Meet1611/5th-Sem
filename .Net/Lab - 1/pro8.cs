using System;

class pro8
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose operation: +, -, *, /");
        char op = Console.ReadLine()[0];

        if (op == '+') Console.WriteLine("Result = " + (num1 + num2));
        else if (op == '-') Console.WriteLine("Result = " + (num1 - num2));
        else if (op == '*') Console.WriteLine("Result = " + (num1 * num2));
        else if (op == '/') Console.WriteLine("Result = " + (num1 / num2));
        else Console.WriteLine("Invalid operation");

        
    }
}
