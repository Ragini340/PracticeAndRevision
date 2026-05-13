using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Classes_And_Objects
{
    public class Employee
    {
        int employeeId = 1001;
        string employeeName = "John";
        double salary = 50000;

        public void DisplayEmployee()
        {
            Console.WriteLine("Employee Id : " + employeeId);
            Console.WriteLine("Employee Name : " + employeeName);
            Console.WriteLine("Salary : " + salary);
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.DisplayEmployee();
        }
    }
}