using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Abstraction.FullAbstraction_Using_Interface
{
    public class LaserPrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing Document");
        }
    }
}