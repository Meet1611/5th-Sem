using System;

namespace Lab_4
{
    internal class RBI
    {
        public double CalculateInterest(double principal, double rate, int time)
        {
            return (principal * rate * time) / 100;
        }
    }

    class HDFC : RBI
    {
        public double CalculateInterest(double principal, double rate, int time)
        {
            double interest = base.CalculateInterest(principal, rate, time);
            return interest;
        }
    }

    class SBI : RBI
    {
        public double CalculateInterest(double principal, double rate, int time)
        {
            double interest = base.CalculateInterest(principal, rate, time);
            return interest;
        }
    }

    class ICICI : RBI
    {
        public double CalculateInterest(double principal, double rate, int time)
        {
            double interest = base.CalculateInterest(principal, rate, time);
            return interest;
        }
    }
}
