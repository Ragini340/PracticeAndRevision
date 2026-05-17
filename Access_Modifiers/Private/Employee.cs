using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Access_Modifiers.Private
{
    public class Employee
    {
        private int employeeId = 1001;

        public void Display()
        {
            Console.WriteLine($"Employee Id : {employeeId}");
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Display();

            Console.WriteLine(employee.employeeId); 
        }

    }
}