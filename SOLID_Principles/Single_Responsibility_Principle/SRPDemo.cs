using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Single_Responsibility_Principle
{
    class SRPDemo
    {
        public void Execute()
        {
            Invoice invoice = new Invoice
            {
                Amount = 2500
            };

            InvoicePrinter printer = new InvoicePrinter();

            printer.Print(invoice);
        }
    }
}