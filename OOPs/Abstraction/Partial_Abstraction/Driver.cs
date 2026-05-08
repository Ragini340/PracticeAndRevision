using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Abstraction.Partial_Abstraction
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Car car = new Car();

            car.Start();
            car.Stop();
        }
    }
}