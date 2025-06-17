using System;

class Bank_Account
{
    int Account_Number;
    string Email;
    string Name;
    string Type;
    double Balance;

    public void getAccountDetails()
    {
        Console.WriteLine("Enter Account Number: ");
        Account_Number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Email: ");
        Email = Console.ReadLine();
        Console.WriteLine("Enter Name: ");
        Name = Console.ReadLine();
        Console.WriteLine("Enter Type (Savings/Current): ");
        Type = Console.ReadLine();
        Console.WriteLine("Enter Balance: ");
        Balance = Convert.ToDouble(Console.ReadLine());
    }

    public void displayAccountDetails()
    {
        Console.WriteLine("Account Number: " + Account_Number);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Type: " + Type);
        Console.WriteLine("Balance: " + Balance);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Bank_Account accounts = new Bank_Account();
        accounts.getAccountDetails();
        accounts.displayAccountDetails();
    }
}