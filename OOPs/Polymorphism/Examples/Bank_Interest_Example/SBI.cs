using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.Examples.Bank_Interest_Example
{
    public class SBI : Bank
    {
        public override double GetInterestRate()
        {
            return 6.5;
        }
    }
}