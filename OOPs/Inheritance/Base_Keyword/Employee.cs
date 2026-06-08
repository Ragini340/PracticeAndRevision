using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Inheritance.Base_Keyword
{
    public class Employee : Person
    {
        public Employee(string name, int id) : base(name)
        {
            Console.WriteLine("Employee Id : " + id);
        }
    }
}