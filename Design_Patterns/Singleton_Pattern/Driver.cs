using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Singleton_Pattern
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            SingletonDemo demo = new SingletonDemo();
            demo.Execute();
        }
    }
}