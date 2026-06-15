using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Event_with_EventArgs
{
    public class Subscriber
    {
        public void HandleEvent(object sender, EventArgs e)
        {
            Console.WriteLine("Event Handled");
        }
    }
}