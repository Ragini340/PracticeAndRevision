using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Adapter_Pattern
{
    class AdapterDemo
    {
        public void Execute()
        {
            IPrinter printer = new PrinterAdapter();

            printer.Print();
        }
    }
}