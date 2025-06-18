using System;

class Program
{
    static void CheckEvenNumber(int number)
    {
        if (number % 2 != 0)
        {
            throw new ArgumentException("The number is not an even number.");
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int userInput = int.Parse(Console.ReadLine());
        try
        {
            CheckEvenNumber(userInput);
            Console.WriteLine($"The number {userInput} is an even number.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}