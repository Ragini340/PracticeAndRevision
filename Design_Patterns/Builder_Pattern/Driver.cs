using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Builder_Pattern
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            BuilderDemo demo = new BuilderDemo();
            demo.Execute();
        }
    }
}