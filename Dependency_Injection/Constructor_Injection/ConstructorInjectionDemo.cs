using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Constructor_Injection
{
    class ConstructorInjectionDemo
    {
        public void Execute()
        {
            IMessageService service = new EmailService();

            Notification notification = new Notification(service);

            notification.Notify();
        }
    }
}