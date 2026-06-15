using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Temperature_Alert_Example
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();

            monitor.HighTemperature += ShowAlert;

            monitor.CheckTemperature(45);
        }

        public static void ShowAlert(object sender, EventArgs e)
        {
            Console.WriteLine("High Temperature Alert");
        }
    }
}