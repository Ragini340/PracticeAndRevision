using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Open_Closed_Principle
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            OCPDemo demo = new OCPDemo();
            demo.Execute();
        }
    }
}