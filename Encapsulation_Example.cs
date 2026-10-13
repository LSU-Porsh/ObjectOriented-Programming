using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank myaccount = new Bank();
            myaccount.AccountId = "BPI123456789";
            myaccount.Deposit(10000);
            myaccount.Deposit(500.25);
            myaccount.Withdraw(5500.75);
            Console.WriteLine($"Current Balance:{myaccount.Balance}");
        }
    }

   class Bank
    {
        private string accountId;
        private double balance;

        public string AccountId {
            get { return accountId; }
            set { accountId = value; }
        }
        //read only property
        public double Balance {
            get {
                    return balance;
               }
        }

        public void Deposit(double amount) {
            Console.WriteLine($"You deposited : {amount}");
            balance += amount;
            Console.WriteLine($"Your new balance is: {balance}");
        }

        public void Withdraw(double amount)
        {
            Console.WriteLine($"You withdrawed : {amount}");
            balance -= amount;
            Console.WriteLine($"Your new balance is: {balance}");
        }
    }
}
