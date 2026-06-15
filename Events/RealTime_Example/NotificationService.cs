using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.RealTime_Example
{
    public class NotificationService
    {
        public void SendNotification(object sender, EventArgs e)
        {
            Console.WriteLine("Email Notification Sent");
        }
    }
}