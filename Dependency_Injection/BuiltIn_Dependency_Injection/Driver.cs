using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.BuiltIn_Dependency_Injection
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            DependencyInjectionDemo demo = new DependencyInjectionDemo();
            demo.Execute();
        }
    }
}