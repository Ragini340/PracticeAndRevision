using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Multiple_Implementations
{
    class MultipleImplementationDemo
    {
        public void Execute()
        {
            Notification email = new Notification(new EmailService());

            Notification sms = new Notification(new SmsService());

            email.Notify();
            sms.Notify();
        }
    }
}