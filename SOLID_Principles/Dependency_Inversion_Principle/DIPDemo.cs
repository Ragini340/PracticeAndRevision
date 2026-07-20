using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Dependency_Inversion_Principle
{
    class DIPDemo
    {
        public void Execute()
        {
            IMessageService service = new EmailService();

            Notification notification = new Notification(service);

            notification.Notify();
        }
    }
}