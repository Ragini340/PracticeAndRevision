using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Abstraction.Abstract_Property
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Manager manager = new Manager();

            manager.EmployeeName = "John";

            Console.WriteLine(manager.EmployeeName);
        }
    }
}