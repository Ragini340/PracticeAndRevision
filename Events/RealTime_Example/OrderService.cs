using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.RealTime_Example
{
    public class OrderService
    {
        public event EventHandler OrderPlaced;

        public void PlaceOrder()
        {
            Console.WriteLine("Order Placed");

            OrderPlaced?.Invoke(this, EventArgs.Empty);
        }
    }
}