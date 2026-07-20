using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.SOLID_with_Repository_Pattern
{
    class EmployeeRepository : IRepository
    {
        public List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee{ Id = 1, Name = "Ragini"},
                new Employee{ Id = 2, Name = "Ragini Singh"}
            };
        }
    }
}