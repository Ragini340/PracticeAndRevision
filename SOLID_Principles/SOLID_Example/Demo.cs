using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.SOLID_Example
{
    class Demo
    {
        public void Execute()
        {
            ILogger logger = new ConsoleLogger();

            OrderService service = new OrderService(logger);

            service.PlaceOrder();
        }
    }
}