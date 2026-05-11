using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Delegates.RealTime_Delegate_Example
{
    public delegate void NotificationDelegate(string message);

    public class NotificationService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine("Email Sent : " + message);
        }

        public void SendSms(string message)
        {
            Console.WriteLine("SMS Sent : " + message);
        }
    }
}