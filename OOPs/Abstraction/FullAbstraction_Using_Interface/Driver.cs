using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Abstraction.FullAbstraction_Using_Interface
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            IPrinter printer = new LaserPrinter();

            printer.Print();
        }
    }
}