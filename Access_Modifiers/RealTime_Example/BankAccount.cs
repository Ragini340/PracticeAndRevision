using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Access_Modifiers.RealTime_Example
{
    public class BankAccount
    {
        private double balance;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Current Balance : " + balance);
        }

        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Deposit(5000);

            account.DisplayBalance();
        }

    }
}