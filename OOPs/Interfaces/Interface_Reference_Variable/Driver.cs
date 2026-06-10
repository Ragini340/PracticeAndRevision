using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Interfaces.Interface_Reference_Variable
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            IShape shape = new Circle();

            shape.Draw();
        }
    }
}