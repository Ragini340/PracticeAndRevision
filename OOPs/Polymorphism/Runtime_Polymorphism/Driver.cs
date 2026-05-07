using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.Runtime_Polymorphism
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Shape shape = new Circle();

            shape.Draw();
        }
    }
}