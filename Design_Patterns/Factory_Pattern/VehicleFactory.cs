using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Factory_Pattern
{
    public class VehicleFactory
    {
        public IVehicle GetVehicle(string type)
        {
            if (type == "Car")
                return new Car();

            return new Bike();
        }
    }
}