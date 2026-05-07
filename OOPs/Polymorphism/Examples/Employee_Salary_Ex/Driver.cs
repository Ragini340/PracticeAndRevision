using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.Examples.Employee_Salary_Ex
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Employee employee;

            employee = new PermanentEmployee();
            Console.WriteLine("Permanent Salary : " + employee.CalculateSalary());

            employee = new ContractEmployee();
            Console.WriteLine("Contract Salary : " + employee.CalculateSalary());
        }
    }
}