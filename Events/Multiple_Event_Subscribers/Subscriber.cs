using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Multiple_Event_Subscribers
{
    public class Subscriber
    {
        public void Method1()
        {
            Console.WriteLine("Subscriber 1 Executed");
        }

        public void Method2()
        {
            Console.WriteLine("Subscriber 2 Executed");
        }
    }
}