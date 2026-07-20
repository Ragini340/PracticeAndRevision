using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.RealTime_SOLID_Example
{
    class SOLIDDemo
    {
        public void Execute()
        {
            PaymentProcessor processor = new PaymentProcessor(new CreditCardPayment());

            processor.Process();
        }
    }
}