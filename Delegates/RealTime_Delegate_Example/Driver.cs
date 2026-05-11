using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Delegates.RealTime_Delegate_Example
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            NotificationService service = new NotificationService();

            NotificationDelegate notification = service.SendEmail;

            notification += service.SendSms;

            notification("Order Placed Successfully");
        }
    }
}