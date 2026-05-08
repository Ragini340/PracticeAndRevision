using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Abstraction.Partial_Abstraction
{
    abstract class Vehicle
    {
        public void Start()
        {
            Console.WriteLine("Vehicle Started");
        }

        public abstract void Stop();
    }
}