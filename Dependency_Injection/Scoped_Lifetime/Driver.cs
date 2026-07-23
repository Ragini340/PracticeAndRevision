using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.Scoped_Lifetime
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            ScopedDemo demo = new ScopedDemo();
            demo.Execute();
        }
    }
}