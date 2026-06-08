using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Encapsulation_And_Properties.PrivateFields_with_Public_Methods
{
    public class Employee
    {
        private int employeeId;
        private string employeeName;

        public void SetEmployee(int id, string name)
        {
            employeeId = id;
            employeeName = name;
        }

        public void DisplayEmployee()
        {
            Console.WriteLine("Employee Id : " + employeeId);
            Console.WriteLine("Employee Name : " + employeeName);
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.SetEmployee(1001, "John");
            employee.DisplayEmployee();
        }
    }
}