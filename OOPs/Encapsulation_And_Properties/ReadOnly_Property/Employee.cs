using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Encapsulation_And_Properties.ReadOnly_Property
{
    public class Employee
    {
        private int employeeId;

        public Employee(int id)
        {
            employeeId = id;
        }

        public int EmployeeId
        {
            get
            {
                return employeeId;
            }
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee(1001);

            Console.WriteLine("Employee Id : " + employee.EmployeeId);
        }
    }
}