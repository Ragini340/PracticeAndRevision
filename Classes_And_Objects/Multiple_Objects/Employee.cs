using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Classes_And_Objects.Multiple_Objects
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
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.SetData(101, "John");

            Employee employee2 = new Employee();
            employee2.SetData(102, "David");

            employee1.Display();
            employee2.Display();
        }
    }
}