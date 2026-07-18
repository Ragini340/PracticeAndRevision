using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Decorator_Pattern
{
    class DecoratorDemo
    {
        public void Execute()
        {
            IMessage message = new SmsDecorator(new Email());

            message.Send();
        }
    }
}