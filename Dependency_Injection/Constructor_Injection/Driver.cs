using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Constructor_Injection
{
    public class Driver
    {
        public void Main(string[] args)
        {
            ConstructorInjectionDemo demo = new ConstructorInjectionDemo();
            demo.Execute();
        }
    }
}