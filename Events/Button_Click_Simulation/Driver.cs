using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Button_Click_Simulation
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Button button = new Button();

            button.Click += Button_Click;

            button.PerformClick();
        }

        public static void Button_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Button Clicked");
        }
    }
}