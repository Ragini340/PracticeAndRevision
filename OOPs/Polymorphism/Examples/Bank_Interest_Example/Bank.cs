using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.Examples.Bank_Interest_Example
{
    public class Bank
    {
        public virtual double GetInterestRate()
        {
            return 0;
        }
    }
}