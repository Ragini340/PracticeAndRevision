using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.ILogger_Injection
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            LoggerDemo demo = new LoggerDemo();
            demo.Execute();
        }
    }
}