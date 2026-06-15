using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Event_Publisher_And_Subscriber
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            publisher.Notification += subscriber.ReceiveNotification;

            publisher.SendNotification();
        }
    }
}