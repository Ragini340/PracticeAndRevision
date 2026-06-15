using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Event_with_EventArgs
{
    public class Publisher
    {
        public event EventHandler Notification;

        public void RaiseEvent()
        {
            Notification?.Invoke(this, EventArgs.Empty);
        }
    }
}