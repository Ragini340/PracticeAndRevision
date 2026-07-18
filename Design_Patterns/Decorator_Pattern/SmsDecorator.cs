using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Decorator_Pattern
{
    class SmsDecorator : IMessage
    {
        private readonly IMessage message;

        public SmsDecorator(IMessage message)
        {
            this.message = message;
        }

        public void Send()
        {
            message.Send();
            Console.WriteLine("SMS Sent");
        }
    }
}