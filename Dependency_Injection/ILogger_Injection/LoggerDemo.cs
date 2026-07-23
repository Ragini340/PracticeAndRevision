using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.ILogger_Injection
{
    class LoggerDemo
    {
        public void Execute()
        {
            ILogger logger = new FileLogger();

            OrderService service = new OrderService(logger);

            service.PlaceOrder();
        }
    }
}