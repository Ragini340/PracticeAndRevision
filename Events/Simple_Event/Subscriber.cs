using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Simple_Event
{
    public class Subscriber
    {
        public void ShowMessage()
        {
            Console.WriteLine("Event Raised");
        }
    }
}