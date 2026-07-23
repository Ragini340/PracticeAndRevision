using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Multiple_Implementations
{
    class SmsService : IMessageService
    {
        public void Send()
        {
            Console.WriteLine("SMS Sent");
        }
    }
}