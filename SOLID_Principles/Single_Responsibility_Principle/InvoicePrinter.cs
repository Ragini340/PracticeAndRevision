using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Single_Responsibility_Principle
{
    class InvoicePrinter
    {
        public void Print(Invoice invoice)
        {
            Console.WriteLine($"Invoice Amount : {invoice.Amount}");
        }
    }
}