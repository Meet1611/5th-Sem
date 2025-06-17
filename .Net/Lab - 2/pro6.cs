using System;

class Account_Details
{
    public string accountHolderName;
    public int accountNumber;
    public double principal;
    public double rate;
    public int time;

    public void GetDetails()
    {
        Console.Write("Enter Account Holder Name: ");
        accountHolderName = Console.ReadLine();

        Console.Write("Enter Account Number: ");
        accountNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Principal Amount: ");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        time = Convert.ToInt32(Console.ReadLine());
    }
}

class Interest : Account_Details
{
    public void CalculateAndDisplayInterest()
    {
        double interest = (principal * rate * time) / 100;
        double totalAmount = principal + interest;

        Console.WriteLine("\n----- Account Summary -----");
        Console.WriteLine("Account Holder Name: " + accountHolderName);
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Principal Amount: " + principal);
        Console.WriteLine("Rate of Interest: " + rate + "%");
        Console.WriteLine("Time: " + time + " years");
        Console.WriteLine("Calculated Interest: " + interest);
        Console.WriteLine("Total Amount after Interest: " + totalAmount);
    }

    static void Main()
    {
        Interest obj = new Interest();
        obj.GetDetails();              
        obj.CalculateAndDisplayInterest();  
    }
}

