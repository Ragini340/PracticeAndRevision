using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Custom_EventArgs
{
    public class Publisher
    {
        public event EventHandler<MessageEventArgs> Notification;

        public void RaiseEvent()
        {
            MessageEventArgs args = new MessageEventArgs
            {
                Message = "Welcome To Events"
            };

            Notification?.Invoke(this, args);
        }
    }
}