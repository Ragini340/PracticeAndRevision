using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Anonymous_Types.AnonymousType_Collection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var employees = new[]
            {
                new { Id = 101, Name = "Ragini" },
                new { Id = 102, Name = "David" },
                new { Id = 103, Name = "Smith" }
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Id + " - " + employee.Name);
            }
        }
    }
}