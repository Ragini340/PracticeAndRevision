using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.File_Handling.RealTime_File_Handling_Example
{
    public class Logger
    {
        private readonly string _logFile = "ApplicationLog.txt";

        public void Log(string message)
        {
            string logMessage = $"{DateTime.Now} : {message}";

            File.AppendAllText(_logFile, logMessage + Environment.NewLine);

            Console.WriteLine("Log Written Successfully.");
        }

        public static void Main(string[] args)
        {
            Logger logger = new Logger();

            logger.Log("Application Started.");
            logger.Log("User Logged In.");
            logger.Log("Application Closed.");
        }
    }
}