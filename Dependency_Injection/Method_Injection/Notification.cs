using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Method_Injection
{
    class Notification
    {
        public void Notify(IMessageService service)
        {
            service.SendMessage();
        }
    }
}