using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.RealTime_Example
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            OrderService orderService = new OrderService();
            NotificationService notificationService = new NotificationService();

            orderService.OrderPlaced += notificationService.SendNotification;

            orderService.PlaceOrder();
        }
    }
}