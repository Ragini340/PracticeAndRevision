using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Constructor_Injection
{
    class EmailService : IMessageService
    {
        public void SendMessage()
        {
            Console.WriteLine("Email Sent");
        }
    }
}