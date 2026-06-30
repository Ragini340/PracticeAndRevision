using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Anonymous_Types.AnonymousType_Projection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee { Id = 101, Name = "Ragini" },
                new Employee { Id = 102, Name = "David" }
            };

            var result =
                employees.Select(employee => new
                {
                    employee.Name
                });

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}