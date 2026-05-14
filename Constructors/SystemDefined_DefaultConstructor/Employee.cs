using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructors.SystemDefined_DefaultConstructor
{
    public class Employee
    {
        private int id;
        private string name;

        public void Display()
        {
            Console.WriteLine($"Id : {id}");
            Console.WriteLine($"Name : {name}");
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Display();
        }
    }
}