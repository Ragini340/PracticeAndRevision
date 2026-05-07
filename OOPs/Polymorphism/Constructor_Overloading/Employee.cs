using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.Constructor_Overloading
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default Constructor");
        }

        public Employee(int id)
        {
            Console.WriteLine("Employee Id : " + id);
        }

        public Employee(int id, string name)
        {
            Console.WriteLine("Employee Id : " + id);
            Console.WriteLine("Employee Name : " + name);
        }

        public static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee(101);
            Employee employee3 = new Employee(101, "John");
        }
    }
}