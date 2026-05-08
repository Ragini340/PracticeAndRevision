using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Abstraction.Partial_Abstraction
{
    class Car : Vehicle
    {
        public override void Stop()
        {
            Console.WriteLine("Vehicle Stopped");
        }
    }
}