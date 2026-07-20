using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.SOLID_with_Repository_Pattern
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            RepositoryDemo demo = new RepositoryDemo();
            demo.Execute();
        }
    }
}