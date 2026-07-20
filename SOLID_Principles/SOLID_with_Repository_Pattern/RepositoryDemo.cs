using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.SOLID_with_Repository_Pattern
{
    class RepositoryDemo
    {
        public void Execute()
        {
            IRepository repository = new EmployeeRepository();

            foreach (Employee employee in repository.GetEmployees())
            {
                Console.WriteLine($"{employee.Id} {employee.Name}");
            }
        }
    }
}