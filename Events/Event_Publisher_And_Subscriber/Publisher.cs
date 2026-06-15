using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Event_Publisher_And_Subscriber
{
    public delegate void NotificationHandler();

    public class Publisher
    {
        public event NotificationHandler Notification;

        public void SendNotification()
        {
            Notification?.Invoke();
        }
    }
}