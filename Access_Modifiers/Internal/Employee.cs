using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Access_Modifiers.Internal
{
    public class Employee
    {
        internal int EmployeeId = 101;

        public void Display()
        {
            Console.WriteLine($"Employee Id : {EmployeeId}");
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.Display();

            Console.WriteLine(employee.EmployeeId);
        }
    }
}