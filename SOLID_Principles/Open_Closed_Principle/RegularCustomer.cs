using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Open_Closed_Principle
{
    class RegularCustomer : IDiscount
    {
        public double GetDiscount(double amount)
        {
            return amount * 0.10;
        }
    }
}