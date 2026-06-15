using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Bank_Transaction_Event
{
    public class BankAccount
    {
        public event EventHandler TransactionCompleted;

        public void Deposit(double amount)
        {
            Console.WriteLine("Amount Deposited : " + amount);

            TransactionCompleted?.Invoke(this, EventArgs.Empty);
        }
    }
}