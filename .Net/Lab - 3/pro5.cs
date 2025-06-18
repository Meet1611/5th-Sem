using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Length of the string
        Console.WriteLine($"Length of the string: {input.Length}");

        // Convert to uppercase
        Console.WriteLine($"Uppercase: {input.ToUpper()}");

        // Convert to lowercase
        Console.WriteLine($"Lowercase: {input.ToLower()}");

        // Check if the string contains a substring
        Console.WriteLine("Enter a substring to check if it exists in the string:");
        string substring = Console.ReadLine();
        bool containsSubstring = input.Contains(substring);
        Console.WriteLine($"Does the string contain '{substring}'? {containsSubstring}");

        // Replace a substring with another substring
        Console.WriteLine("Enter a substring to replace:");
        string oldSubstring = Console.ReadLine();

        Console.WriteLine("Enter a new substring to replace it with:");
        string newSubstring = Console.ReadLine();

        string replacedString = input.Replace(oldSubstring, newSubstring);
        Console.WriteLine($"Replaced String: {replacedString}");

        // Split the string into an array of words
        string[] words = input.Split(' ');
        Console.WriteLine("Words in the string:");

        foreach (var word in words)
        {
            Console.WriteLine(word);
        }

    }
}