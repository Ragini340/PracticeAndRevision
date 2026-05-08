using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Abstraction.AbstractClass_with_Constructor
{
    class Employee : Person
    {
        public Employee()
        {
            Console.WriteLine("Derived Class Constructor");
        }
    }
}