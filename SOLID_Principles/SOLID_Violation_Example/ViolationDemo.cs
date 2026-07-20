using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.SOLID_Violation_Example
{
    class ViolationDemo
    {
        public void Execute()
        {
            Employee employee = new Employee();

            employee.Save();
            employee.Print();
            employee.SendEmail();
        }
    }
}