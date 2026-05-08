using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Abstraction.Examples.Bank_Example
{
    class SBI : Bank
    {
        public override double GetInterestRate()
        {
            return 6.5;
        }
    }
}