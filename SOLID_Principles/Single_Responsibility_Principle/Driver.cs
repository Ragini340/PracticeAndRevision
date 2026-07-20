using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeAndRevision.SOLID_Principles.Single_Responsibility_Principle;

namespace PracticeAndRevision.SOLID_Principles.Single_Responsibility_Principle
{
    class Driver
    {
        public static void Main(string[] args)
        {
            SRPDemo demo = new SRPDemo();
            demo.Execute();
        }
    }
}