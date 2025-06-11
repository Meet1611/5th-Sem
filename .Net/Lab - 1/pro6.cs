using System;

class pro6
{
    static double CelsiusToFahrenheit(double celsius) => (celsius * 9 / 5) + 32;

    static double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) * 5 / 9;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Temperature Conversion Menu:");
            Console.WriteLine("1. Celsius to Fahrenheit\n2. Fahrenheit to Celsius");

            Console.Write("Choose: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter Celsius: ");
                double c = double.Parse(Console.ReadLine());

                Console.WriteLine("Fahrenheit = " + CelsiusToFahrenheit(c));
            }
            else if (choice == 2)
            {
                Console.Write("Enter Fahrenheit: ");
                double f = double.Parse(Console.ReadLine());

                Console.WriteLine("Celsius = " + FahrenheitToCelsius(f));
            }
            else
            {
                Console.WriteLine("Invalid choice");
                break;
            }
        }
    }
}