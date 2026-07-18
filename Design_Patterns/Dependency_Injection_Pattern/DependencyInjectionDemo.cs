using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Dependency_Injection_Pattern
{
    class DependencyInjectionDemo
    {
        public void Execute()
        {
            IMessageService service = new EmailService();

            Notification notification = new Notification(service);

            notification.Notify();
        }
    }
}