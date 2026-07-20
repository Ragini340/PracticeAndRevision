using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Liskov_Substitution_Principle
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            LSPDemo demo = new LSPDemo();
            demo.Execute();
        }
    }
}