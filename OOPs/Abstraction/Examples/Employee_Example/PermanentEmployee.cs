using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Abstraction.Examples.Employee_Example
{
    class PermanentEmployee : Employee
    {
        public override double CalculateSalary()
        {
            return 50000;
        }
    }
}