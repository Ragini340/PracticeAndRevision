using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Interface_Segregation_Principle
{
    class ISPDemo
    {
        public void Execute()
        {
            MultiFunctionPrinter printer = new MultiFunctionPrinter();

            printer.Print();
            printer.Scan();
        }
    }
}