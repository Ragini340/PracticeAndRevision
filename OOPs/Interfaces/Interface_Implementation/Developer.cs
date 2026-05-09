using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Interfaces.Interface_Implementation
{
    public class Developer : IEmployee
    {
        public void Work()
        {
            Console.WriteLine("Developer is Working");
        }
    }
}