using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Builder_Pattern
{
    public class ComputerBuilder
    {
        private readonly Computer computer = new Computer();

        public ComputerBuilder SetCPU(string cpu)
        {
            computer.CPU = cpu;
            return this;
        }

        public ComputerBuilder SetRAM(string ram)
        {
            computer.RAM = ram;
            return this;
        }

        public Computer Build()
        {
            return computer;
        }
    }
}