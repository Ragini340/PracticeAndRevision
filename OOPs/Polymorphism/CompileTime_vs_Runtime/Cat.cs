using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.CompileTime_vs_Runtime
{
    public class Cat : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Cat Meows");
        }
    }
}