using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Interfaces.Multiple_Interface_Implementation
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            MultiFunctionDevice device = new MultiFunctionDevice();

            device.Print();
            device.Scan();
        }
    }
}