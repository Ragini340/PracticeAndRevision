using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Method_Injection
{
    class MethodInjectionDemo
    {
        public void Execute()
        {
            Notification notification = new Notification();

            notification.Notify(new WhatsAppService());
        }
    }
}