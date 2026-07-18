using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Repository_Pattern
{
    class RepositoryDemo
    {
        public void Execute()
        {
            IEmployeeRepository repository = new EmployeeRepository();

            List<Employee> employees = repository.GetEmployees();

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Id} - {employee.Name}");
            }
        }
    }
}