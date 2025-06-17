using System;

interface Gross
{
    void Gross_sal();
}

class Employee
{
    protected string Name;
    protected double Basic;

    public void basic_sal()
    {
        Console.Write("Enter Employee Name: ");
        Name = Console.ReadLine();

        Console.Write("Enter Basic Salary: ");
        Basic = Convert.ToDouble(Console.ReadLine());
    }
}

class Salary : Employee, Gross
{
    private double HRA, TA, DA, GrossSalary;

    public void Gross_sal()
    {
        HRA = 0.20 * Basic; 
        TA = 0.10 * Basic;  
        DA = 0.15 * Basic;  

        GrossSalary = Basic + HRA + TA + DA;
    }

    public void Disp_sal()
    {
        Console.WriteLine("\n--- Employee Salary Details ---");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Basic Salary: " + Basic);
        Console.WriteLine("HRA (20%): " + HRA);
        Console.WriteLine("TA (10%): " + TA);
        Console.WriteLine("DA (15%): " + DA);
        Console.WriteLine("Gross Salary: " + GrossSalary);
    }

    static void Main()
    {
        Salary s = new Salary();
        s.basic_sal();
        s.Gross_sal();     
        s.Disp_sal();     
    }
}
