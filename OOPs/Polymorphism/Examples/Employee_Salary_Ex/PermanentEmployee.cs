using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.Examples.Employee_Salary_Ex
{
    public class PermanentEmployee : Employee
    {
        public override double CalculateSalary()
        {
            return 50000;
        }
    }
}