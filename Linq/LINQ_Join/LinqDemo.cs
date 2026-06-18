using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Linq.LINQ_Join
{
    public class LinqDemo
    {
        public void Execute()
        {
            Employee[] employees =
            {
                new Employee { DepartmentId = 1, Name = "John" },
                new Employee { DepartmentId = 2, Name = "David" }
            };

            Department[] departments =
            {
                new Department { DepartmentId = 1, DepartmentName = "HR" },
                new Department { DepartmentId = 2, DepartmentName = "IT" }
            };

            var result =
                employees.Join(
                    departments,
                    employee => employee.DepartmentId,
                    department => department.DepartmentId,
                    (employee, department) => new
                    {
                        employee.Name,
                        department.DepartmentName
                    });

            foreach (var item in result)
            {
                Console.WriteLine(item.Name + " - " + item.DepartmentName);
            }
        }
    }
}