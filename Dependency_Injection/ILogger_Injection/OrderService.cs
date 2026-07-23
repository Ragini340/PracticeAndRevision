using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.ILogger_Injection
{
    class OrderService
    {
        private readonly ILogger logger;

        public OrderService(ILogger logger)
        {
            this.logger = logger;
        }

        public void PlaceOrder()
        {
            logger.Log("Order Placed Successfully");
        }
    }
}