using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Lambda_Expressions.Lambda_with_Custom_Object
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
                {
                    new Employee { Id = 101, Name = "John" },
                    new Employee { Id = 102, Name = "David" }
                };

            var result = employees.Where(employee => employee.Id == 101);

            foreach (Employee employee in result)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}