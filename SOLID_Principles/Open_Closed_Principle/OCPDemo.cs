using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Open_Closed_Principle
{
    class OCPDemo
    {
        public void Execute()
        {
            IDiscount customer = new PremiumCustomer();

            Console.WriteLine(customer.GetDiscount(5000));
        }
    }
}