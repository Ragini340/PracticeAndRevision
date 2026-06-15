using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Temperature_Alert_Example
{
    public class TemperatureMonitor
    {
        public event EventHandler HighTemperature;

        public void CheckTemperature(int temperature)
        {
            if (temperature > 40)
            {
                HighTemperature?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}