using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Event_Publisher_And_Subscriber
{
    public class Subscriber
    {
        public void ReceiveNotification()
        {
            Console.WriteLine("Notification Received");
        }
    }
}