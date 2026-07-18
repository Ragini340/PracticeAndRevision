using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Repository_Pattern
{
    interface IEmployeeRepository
    {
        List<Employee> GetEmployees();
    }
}