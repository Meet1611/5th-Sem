using System;

class Student
{
    string Name;
    int enrollmentNumber;
    int semester;
    double CPI;
    double SPI;

    public Student(int enrollmentNumber, string Name, int semester, double CPI, double SPI)
    {
        this.enrollmentNumber = enrollmentNumber;
        this.Name = Name;
        this.semester = semester;
        this.CPI = CPI;
        this.SPI = SPI;
    }
    
    public void displayStudentDetails()
    {
        Console.WriteLine("Enrollment Number: " + enrollmentNumber);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Semester: " + semester);
        Console.WriteLine("CPI: " + CPI);
        Console.WriteLine("SPI: " + SPI);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter Enrollment Number: ");
        int enrollmentNumber = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter Name: ");
        string Name = Console.ReadLine();
        
        Console.WriteLine("Enter Semester: ");
        int semester = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter CPI: ");
        double CPI = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter SPI: ");
        double SPI = Convert.ToDouble(Console.ReadLine());
        Student student = new Student(enrollmentNumber, Name, semester, CPI, SPI);
        student.displayStudentDetails();
    }
}