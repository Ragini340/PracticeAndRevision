using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Method_Injection
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            MethodInjectionDemo demo = new MethodInjectionDemo();
            demo.Execute();
        }
    }
}