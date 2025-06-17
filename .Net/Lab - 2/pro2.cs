using System;

class Staff
{
    string Name;
    string Department;
    string Designation;
    int Experince;
    double Salary;

    public void getStaffDetails()
    {
        Console.WriteLine("Enter Staff Name : ");
        Name = Console.ReadLine();
        Console.WriteLine("Enter Staff Department : ");
        Department = Console.ReadLine();
        Console.WriteLine("Enter Staff Designation : ");
        Designation = Console.ReadLine();
        Console.WriteLine("Enter Staff Experience (in years) : ");
        Experince = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Staff Salary : ");
        Salary = Convert.ToDouble(Console.ReadLine());
    }

    public string getName()
    {
        return Name;
    }

    public double getSalary()
    {
        return Salary;
    }

    public string getDesignation()
    {
        return Designation;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Staff[] s = new Staff[5];
        for (int i = 0; i < s.Length; i++)
        {
            s[i] = new Staff();
            Console.WriteLine("Enter details for Staff " + (i + 1) + ":");
            s[i].getStaffDetails();
        }

        for(int i = 0; i < s.Length; i++)
        {
            if (s[i].getDesignation() == "HOD")
            {
                Console.WriteLine("Name : " + s[i].getName());
                Console.WriteLine("Salary : " + s[i].getSalary());
            }
        }
    }
}