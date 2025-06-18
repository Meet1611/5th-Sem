// Write a program to nd the longest word in a string.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string : ");
        string s = Console.ReadLine();
        string[] words = s.Split(' ');
        string longest = "";

        foreach(string word in words) {
            if(word.Length > longest.Length)
            {
                longest = word;
            }
        }

        Console.WriteLine("logest lenght word : " + longest);
    }
}