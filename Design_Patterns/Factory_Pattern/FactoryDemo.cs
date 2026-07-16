using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Factory_Pattern
{
    public class FactoryDemo
    {
        public void Execute()
        {
            VehicleFactory factory = new VehicleFactory();

            IVehicle vehicle = factory.GetVehicle("Car");

            vehicle.Drive();
        }
    }
}