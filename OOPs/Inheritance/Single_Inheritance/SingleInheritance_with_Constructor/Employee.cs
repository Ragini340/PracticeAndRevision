using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Inheritance.Single_Inheritance.SingleInheritance_with_Constructor
{
    public class Employee : Person
    {
        public Employee()
        {
            Console.WriteLine("Employee Constructor");
        }
    }
}