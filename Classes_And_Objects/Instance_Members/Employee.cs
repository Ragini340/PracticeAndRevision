using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Classes_And_Objects.Instance_Members
{
    public class Employee
    {
        int employeeId;
        string employeeName;

        public void SetData(int id, string name)
        {
            employeeId = id;
            employeeName = name;
        }

        public void Display()
        {
            Console.WriteLine("Employee Id : " + employeeId);
            Console.WriteLine("Employee Name : " + employeeName);
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.SetData(101, "David");
            employee.Display();
        }
    }
}