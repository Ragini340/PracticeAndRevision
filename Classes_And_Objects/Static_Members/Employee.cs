using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Classes_And_Objects.Static_Members
{
    public class Employee
    {
        public static string CompanyName = "ABC Technologies";

        public void Display()
        {
            Console.WriteLine("Company : " + CompanyName);
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Display();
        }
    }
}