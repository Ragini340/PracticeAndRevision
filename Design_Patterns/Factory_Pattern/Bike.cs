using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Factory_Pattern
{
    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Bike is Running");
        }
    }
}