using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Inheritance.Inheritance_Examples.Employee_Branch_Ex
{
    public class Employee : Branch
    {
        private int employeeId = 101;
        private string employeeName = "John";

        public void Display()
        {
            Console.WriteLine("Employee Id : " + employeeId);
            Console.WriteLine("Employee Name : " + employeeName);
            Console.WriteLine("Branch Name : " + branchName);
        }
    }
}