using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.SOLID_Violation_Example
{
    class Employee
    {
        public void Save()
        {
            Console.WriteLine("Saving Employee");
        }

        public void Print()
        {
            Console.WriteLine("Printing Employee");
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending Email");
        }
    }
}