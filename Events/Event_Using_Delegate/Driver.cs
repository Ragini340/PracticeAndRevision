using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Event_Using_Delegate
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.EmployeeCreated += ShowEmployee;

            employee.CreateEmployee("John");
        }

        public static void ShowEmployee(string name)
        {
            Console.WriteLine("Employee Created : " + name);
        }
    }
}