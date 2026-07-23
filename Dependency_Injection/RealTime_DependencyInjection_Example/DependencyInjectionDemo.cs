using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.RealTime_DependencyInjection_Example
{
    class DependencyInjectionDemo
    {
        public void Execute()
        {
            IPaymentGateway gateway = new RazorPayGateway();

            PaymentService service = new PaymentService(gateway);

            service.ProcessPayment();
        }
    }
}