using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Builder_Pattern
{
    public class BuilderDemo
    {
        public void Execute()
        {
            Computer computer = new ComputerBuilder()
                .SetCPU("Intel i9")
                .SetRAM("32 GB")
                .Build();

            computer.Show();
        }
    }
}