using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Classes_And_Objects.TypesOfClasses.Internal
{
    internal class Employee
    {
        public void Display()
        {
            Console.WriteLine("Internal Class Accessed Successfully");
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Display();
        }
    }
}