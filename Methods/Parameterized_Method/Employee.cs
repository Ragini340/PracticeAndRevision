using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Methods.Parameterized_Method
{
    public class Employee
    {
        public void Display(int id, string name)
        {
            Console.WriteLine("Employee Id : " + id);
            Console.WriteLine("Employee Name : " + name);
        }

        public static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Display(101, "John");
        }
    }
}