using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Interfaces.Interface_vs_AbstractClass
{
    class EmailNotification : Notification, IMessage
    {
        public void ShowMessage()
        {
            Console.WriteLine("Email Sent");
        }
    }
}