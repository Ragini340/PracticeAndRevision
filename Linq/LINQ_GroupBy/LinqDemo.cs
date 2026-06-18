using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Linq.LINQ_GroupBy
{
    public class LinqDemo
    {
        public void Execute()
        {
            Employee[] employees =
            {
                new Employee { Name = "John", Department = "HR" },
                new Employee { Name = "David", Department = "IT" },
                new Employee { Name = "Smith", Department = "HR" }
            };

            var groups = employees.GroupBy(employee => employee.Department);

            foreach (var group in groups)
            {
                Console.WriteLine("Department : " + group.Key);

                foreach (Employee employee in group)
                {
                    Console.WriteLine(employee.Name);
                }

                Console.WriteLine();
            }
        }
    }
}