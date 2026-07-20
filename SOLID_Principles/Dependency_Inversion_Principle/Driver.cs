using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Dependency_Inversion_Principle
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            DIPDemo demo = new DIPDemo();
            demo.Execute();
        }
    }
}