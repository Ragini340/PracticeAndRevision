using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Custom_EventArgs
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            publisher.Notification += subscriber.HandleEvent;

            publisher.RaiseEvent();
        }
    }
}