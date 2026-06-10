using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Interfaces.Examples.Payment_Gateway_Ex
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            IPayment payment;

            payment = new CreditCardPayment();
            payment.Pay(5000);

            payment = new UpiPayment();
            payment.Pay(3000);
        }
    }
}