using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Property_Injection
{
    class Notification
    {
        public IMessageService MessageService { get; set; }

        public void Notify()
        {
            MessageService.SendMessage();
        }
    }
}