using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Interfaces.Examples.Notification_Service__Ex
{
    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS : " + message);
        }
    }
}