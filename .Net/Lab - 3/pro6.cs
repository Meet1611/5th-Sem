using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();

        for(int i = 0; i < input.Length; i++)
        {
            if (char.IsLower(arr[i]))
            {
                arr[i] = char.ToUpper(arr[i]);
            }
            else
            {
                arr[i] = char.ToLower(arr[i]);
            }
        }
        string ans = new string(arr);
        Console.WriteLine(ans);
    }
}