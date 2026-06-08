using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Encapsulation_And_Properties.RealTime_Encapsulation_Example
{
    public class BankAccount
    {
        private double balance;

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Balance : " + balance);
        }

        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.Balance = 5000;

            account.DisplayBalance();
        }
    }
}