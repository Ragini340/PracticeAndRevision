using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Interfaces.Interface_vs_AbstractClass
{
    abstract class Notification
    {
        public void Display()
        {
            Console.WriteLine("Notification Displayed");
        }
    }
}