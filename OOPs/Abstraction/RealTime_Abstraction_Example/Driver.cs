using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Abstraction.RealTime_Abstraction_Example
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Payment payment = new CreditCardPayment();

            payment.Pay(5000);
        }
    }
}