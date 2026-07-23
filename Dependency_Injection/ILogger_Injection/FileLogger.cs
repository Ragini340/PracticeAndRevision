using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Dependency_Injection.ILogger_Injection
{
    class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log : " + message);
        }
    }
}