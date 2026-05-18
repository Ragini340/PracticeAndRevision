using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructors.Base_Constructor
{
    public class Employee : Person
    {
        public Employee(string name, int id) : base(name)
        {
            Console.WriteLine("Employee Id : " + id);
        }
    }
}