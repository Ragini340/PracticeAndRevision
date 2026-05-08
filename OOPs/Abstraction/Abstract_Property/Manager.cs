using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Abstraction.Abstract_Property
{
    class Manager : Employee
    {
        private string employeeName;

        public override string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
    }
}