using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.RealTime_DependencyInjection_Example
{
    interface IPaymentGateway
    {
        void Pay(decimal amount);
    }
}