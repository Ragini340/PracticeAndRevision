using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.Virtual_Method
{
    public class Employee
    {
        public virtual void DisplayRole()
        {
            Console.WriteLine("Employee");
        }
    }
}