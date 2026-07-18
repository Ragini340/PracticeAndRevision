using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Decorator_Pattern
{
    class Email : IMessage
    {
        public void Send()
        {
            Console.WriteLine("Email Sent");
        }
    }
}