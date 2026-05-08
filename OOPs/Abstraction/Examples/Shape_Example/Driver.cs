using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Abstraction.Examples.Shape_Example
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Circle circle = new Circle();

            Console.WriteLine("Area = " + circle.CalculateArea());
        }
    }
}