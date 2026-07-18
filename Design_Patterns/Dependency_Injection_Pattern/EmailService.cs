using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Dependency_Injection_Pattern
{
    class EmailService : IMessageService
    {
        public void Send()
        {
            Console.WriteLine("Email Sent");
        }
    }
}