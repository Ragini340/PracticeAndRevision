using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeAndRevision.Design_Patterns.Abstract_Factory_Pattern;

namespace PracticeAndRevision.Design_Patterns.Abstract_Factory_Pattern
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            AbstractFactoryDemo demo = new AbstractFactoryDemo();
            demo.Execute();
        }
    }
}