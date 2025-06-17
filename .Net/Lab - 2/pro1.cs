using System;

class Candidate
{
    int ID;
    string Name;
    string Weight;
    string Height;

    public void getCandidateDetails()
    {
        Console.WriteLine("Enter Candidate ID : ");
        ID = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Candidate Name : ");
        Name = Console.ReadLine();
        Console.WriteLine("Enter Candidate Weight : ");
        Weight = Console.ReadLine();
        Console.WriteLine("Enter Candidate Height : ");
        Height = Console.ReadLine();
    }

    public void displayCandidateDetails()
    {
        Console.WriteLine("Candidate ID : " + ID);
        Console.WriteLine("Candidate Name : " + Name);
        Console.WriteLine("Candidate Weight : " + Weight);
        Console.WriteLine("Candidate Height : " + Height);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Candidate c1 = new Candidate();
        c1.getCandidateDetails();
        c1.displayCandidateDetails();
    }
}