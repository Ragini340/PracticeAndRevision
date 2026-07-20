using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.RealTime_SOLID_Example
{
    class PaymentProcessor
    {
        private readonly IPayment payment;

        public PaymentProcessor(IPayment payment)
        {
            this.payment = payment;
        }

        public void Process()
        {
            payment.Pay(5000);
        }
    }
}