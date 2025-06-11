using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your Name : ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter your Address : ");
        string address = Console.ReadLine();

        Console.WriteLine("Enter your Number : ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your city : ");
        string city = Console.ReadLine();

        Console.WriteLine("Hello, " + name + "!");
        Console.WriteLine("Your Address is: " + address);
        Console.WriteLine("Your Number is: " + number);
        Console.WriteLine("Your City is: " + city);
    }
}
