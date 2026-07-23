using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Property_Injection
{
    class PropertyInjectionDemo
    {
        public void Execute()
        {
            Notification notification = new Notification();

            notification.MessageService = new SmsService();

            notification.Notify();
        }
    }
}