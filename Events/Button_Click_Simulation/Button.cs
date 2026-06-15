using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Button_Click_Simulation
{
    public class Button
    {
        public event EventHandler Click;

        public void PerformClick()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
}