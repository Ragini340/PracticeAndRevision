using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Adapter_Pattern
{
    class PrinterAdapter : IPrinter
    {
        private readonly LegacyPrinter printer = new LegacyPrinter();

        public void Print()
        {
            printer.PrintOld();
        }
    }
}