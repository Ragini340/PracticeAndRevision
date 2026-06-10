using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Interfaces.Examples.Notification_Service__Ex
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            INotification notification;

            notification = new EmailNotification();
            notification.Send("Welcome User");

            notification = new SmsNotification();
            notification.Send("OTP Sent Successfully");
        }
    }
}