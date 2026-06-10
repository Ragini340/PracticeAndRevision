using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Interfaces.Examples.Payment_Gateway_Ex
{
    public class UpiPayment : IPayment
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Paid Through UPI : " + amount);
        }
    }
}