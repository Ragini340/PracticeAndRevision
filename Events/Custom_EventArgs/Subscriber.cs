using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Custom_EventArgs
{
    public class Subscriber
    {
        public void HandleEvent(object sender, MessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}