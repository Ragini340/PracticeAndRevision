using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Encapsulation_And_Properties.WriteOnly_Property
{
    public class Employee
    {
        private string employeeName;

        public string EmployeeName
        {
            set
            {
                employeeName = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("Employee Name : " + employeeName);
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.EmployeeName = "John";

            employee.Display();
        }
    }
}