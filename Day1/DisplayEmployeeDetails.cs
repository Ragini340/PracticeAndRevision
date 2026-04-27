using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Day1
{
    public class DisplayEmployeeDetails
    {
        public void DisplayEmployee()
        {
            int empId = 101;
            string empName = "John";
            double salary = 50000;

            Console.WriteLine("Employee Id : " + empId);
            Console.WriteLine("Employee Name : " + empName);
            Console.WriteLine("Salary : " + salary);
        }

        public static void Main(string[] args)
        {
            DisplayEmployeeDetails emp = new DisplayEmployeeDetails();
            emp.DisplayEmployee();
        }
    }
}