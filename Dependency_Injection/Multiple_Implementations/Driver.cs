using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Multiple_Implementations
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            MultipleImplementationDemo demo = new MultipleImplementationDemo();
            demo.Execute();
        }
    }
}