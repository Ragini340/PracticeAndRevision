using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.RealTime_DependencyInjection_Example
{
    class PaymentService
    {
        private readonly IPaymentGateway gateway;

        public PaymentService(IPaymentGateway gateway)
        {
            this.gateway = gateway;
        }

        public void ProcessPayment()
        {
            gateway.Pay(2500);
        }
    }
}