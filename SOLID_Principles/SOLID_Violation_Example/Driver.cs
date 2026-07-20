using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.SOLID_Violation_Example
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            ViolationDemo demo = new ViolationDemo();
            demo.Execute();
        }
    }
}