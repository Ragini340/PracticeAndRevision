using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Dependency_Inversion_Principle
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
            service.Send("Welcome User");
        }
    }
}