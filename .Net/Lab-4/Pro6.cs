using System;

namespace LAB_4
{
    internal class BankAccount
    {
        float intialBalance = 0;
        string accountHolderName = "";
        public BankAccount(int intialBalance, string accountHolderName)
        {
            this.intialBalance = intialBalance;
            this.accountHolderName = accountHolderName;
        }

        public void deposite(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Add sufficent amount");
            }
            else
            {
                this.intialBalance += amount;
                Console.WriteLine($"{amount} deposite successful");
                Console.WriteLine("\nNew Balance:" + this.intialBalance);
            }
        }
        public void withdraw(int amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("\nAdd sufficent amount");
            }
            else if (this.intialBalance < amount)
            {
                Console.WriteLine("\nNot sufficent balance to withdraw amount");
            }
            else
            {
                this.intialBalance -= amount;
                Console.WriteLine($"\n{amount} withdraw successful");
                Console.WriteLine("\nNew Balance:" + this.intialBalance);
            }

        }
    }
}