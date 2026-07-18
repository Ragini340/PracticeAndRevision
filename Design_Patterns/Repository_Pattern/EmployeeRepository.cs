using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Repository_Pattern
{
    class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee { Id = 101, Name = "Ragini" },
                new Employee { Id = 102, Name = "Ragini Ragini" }
            };
        }
    }
}