using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Bank_Transaction_Event
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.TransactionCompleted += TransactionCompleted;

            account.Deposit(5000);
        }

        public static void TransactionCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Transaction Successful");
        }
    }
}