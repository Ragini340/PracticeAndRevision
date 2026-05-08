using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Abstraction.Examples.Shape_Example
{
    class Circle : Shape
    {
        private double radius = 5;

        public override double CalculateArea()
        {
            return 3.14 * radius * radius;
        }
    }
}