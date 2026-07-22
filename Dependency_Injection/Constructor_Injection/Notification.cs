using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Constructor_Injection
{
    class Notification
    {
        private readonly IMessageService service;

        public Notification(IMessageService service)
        {
            this.service = service;
        }

        public void Notify()
        {
            service.SendMessage();
        }
    }
}