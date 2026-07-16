using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Singleton_Pattern
{
    public class SingletonDemo
    {
        public void Execute()
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("Singleton Object Created");

            Console.WriteLine(object.ReferenceEquals(logger1, logger2));
        }
    }
}