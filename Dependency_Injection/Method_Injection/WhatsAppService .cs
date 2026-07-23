using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Method_Injection
{
    class WhatsAppService : IMessageService
    {
        public void SendMessage()
        {
            Console.WriteLine("WhatsApp Message Sent");
        }
    }
}