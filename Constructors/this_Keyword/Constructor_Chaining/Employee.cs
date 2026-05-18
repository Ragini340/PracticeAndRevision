using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructors.this_Keyword.Constructor_Chaining
{
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default Constructor");
        }

        public Employee(int id) : this()
        {
            Console.WriteLine("Employee Id : " + id);
        }

        public Employee(int id, string name) : this(id)
        {
            Console.WriteLine("Employee Name : " + name);
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee(101, "John");
        }
    }
}