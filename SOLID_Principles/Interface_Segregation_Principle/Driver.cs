using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Interface_Segregation_Principle
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            ISPDemo demo = new ISPDemo();
            demo.Execute();
        }
    }
}