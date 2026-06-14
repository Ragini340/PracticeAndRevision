using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Simple_Event
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            publisher.Notify += subscriber.ShowMessage;

            publisher.RaiseEvent();
        }
    }
}