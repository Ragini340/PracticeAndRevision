using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Exception_Handling.Real_Time_Example
{
    public class BankAccount
    {
        private double balance = 5000;

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new Exception("Insufficient Balance");
            }

            balance -= amount;

            Console.WriteLine("Withdrawal Successful");
            Console.WriteLine("Remaining Balance : " + balance);
        }

        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            try
            {
                account.Withdraw(7000);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}