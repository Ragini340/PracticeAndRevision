using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Builder_Pattern
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }

        public void Show()
        {
            Console.WriteLine(CPU);
            Console.WriteLine(RAM);
        }
    }
}