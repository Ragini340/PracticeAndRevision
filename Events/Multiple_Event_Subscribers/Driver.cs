using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Multiple_Event_Subscribers
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            publisher.Notify += subscriber.Method1;
            publisher.Notify += subscriber.Method2;

            publisher.RaiseEvent();
        }
    }
}