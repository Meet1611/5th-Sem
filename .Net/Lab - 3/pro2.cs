using System;

public class Program
{
    public static void Main(string[] args)
    {
        int n = 5;
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter " + (i + 1) + " number : ");
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        try
        {
            Console.WriteLine("Enter index to access: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value at index " + index + " is: " + arr[index]);
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}