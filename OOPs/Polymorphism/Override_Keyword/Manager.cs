using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.Override_Keyword
{
    public class Manager : Employee
    {
        public override void DisplayRole()
        {
            Console.WriteLine("Manager");
        }
    }
}