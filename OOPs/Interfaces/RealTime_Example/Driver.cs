using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Interfaces.RealTime_Example
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            ILogger logger = new FileLogger();

            logger.Log("Application Started");
        }
    }
}