using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Strategy_Pattern
{
    class StrategyDemo
    {
        public void Execute()
        {
            PaymentContext context = new PaymentContext();

            context.Process(new UPI());
        }
    }
}