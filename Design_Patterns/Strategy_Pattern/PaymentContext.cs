using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Strategy_Pattern
{
    class PaymentContext
    {
        public void Process(IPayment payment)
        {
            payment.Pay();
        }
    }
}