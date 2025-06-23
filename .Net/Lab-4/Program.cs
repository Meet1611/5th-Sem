// See https://aka.ms/new-console-template for more information
using LAB_4;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pro1 pro1 = new Pro1();
            //Console.WriteLine("Adding two integers: " + pro1.add(5, 10));
            //Console.WriteLine("Adding two floats: " + pro1.add(5.5f, 10.2f));

            //Pro2 pro2 = new Pro2();
            //Console.WriteLine("Calculating area of a circle with radius 5: " + pro2.CalculateArea(5));
            //Console.WriteLine("Calculating area of a rectangle with length 5 and width 10: " + pro2.CalculateArea(5, 10));

            //HDFC hdfc = new HDFC();
            //Console.WriteLine("HDFC : " + hdfc.CalculateInterest(10000, 5, 2));
            //SBI sbi = new SBI();
            //sbi.CalculateInterest(10000, 6, 2);
            //Console.WriteLine("SBI : " + sbi.CalculateInterest(10000, 7, 2));
            //ICICI icici = new ICICI();
            //icici.CalculateInterest(10000, 7, 2);
            //Console.WriteLine("ICICI : " + icici.CalculateInterest(10000, 9, 2));

            //Hospital hospital = new Hospital();
            //hospital.HospitalDetails();
            //Apollo apollo = new Apollo();
            //apollo.HospitalDetails();
            //Wockhardt wockhardt = new Wockhardt();  
            //wockhardt.HospitalDetails();
            //Gokul_Superspeciality gokul_Superspeciality = new Gokul_Superspeciality();
            //gokul_Superspeciality.HospitalDetails();

            //Square square = new Square();
            //Console.WriteLine("Area of Square : " + square.CalculateArea(3));
            //Rectangle rectangle = new Rectangle();
            //Console.WriteLine("Area of Rectangle : " + rectangle.CalculateArea(3, 4));
            //Circle circle = new Circle();
            //Console.WriteLine("Area of Circle : " + circle.CalculateArea(4));

            BankAccount bankAcc = new BankAccount(100000, "Sumit Vadhava");
            bankAcc.deposite(1000);
            bankAcc.withdraw(10000);
        }
    }
}