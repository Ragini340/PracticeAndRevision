using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Classes_And_Objects.TypesOfClasses.Public
{
    public class Employee
    {
        public void Display()
        {
            Console.WriteLine("Public Class Accessed Successfully");
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Display();
        }
    }
}