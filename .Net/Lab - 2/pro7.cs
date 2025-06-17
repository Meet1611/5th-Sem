using System;

class Salary
{
    private double Basic, TA, DA, HRA, Total;

    public Salary(double basic, double ta, double da = 500, double hra = 1000)
    {
        Basic = basic;
        TA = ta;
        DA = da;
        HRA = hra;
    }

    public void CalculateSalary()
    {
        Total = Basic + TA + DA + HRA;
    }

    public void Display()
    {
        Console.WriteLine("\n--- Salary Details ---");
        Console.WriteLine("Basic Salary: " + Basic);
        Console.WriteLine("TA: " + TA);
        Console.WriteLine("DA: " + DA);
        Console.WriteLine("HRA: " + HRA);
        Console.WriteLine("Total Salary: " + Total);
    }

    static void Main()
    {
        Salary emp1 = new Salary(15000, 2000);
        emp1.CalculateSalary();
        emp1.Display();
    }
}
