using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Decorator_Pattern
{
    class Driver
    {
        public static void Main(string[] args)
        {
            DecoratorDemo demo = new DecoratorDemo();
            demo.Execute();
        }
    }
}