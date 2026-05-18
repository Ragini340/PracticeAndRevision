using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructors.Static_Constructor
{
    public class Employee
    {
        static Employee()
        {
            Console.WriteLine("Static Constructor Called");
        }

        public Employee()
        {
            Console.WriteLine("Instance Constructor Called");
        }

        public static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
        }
    }
}