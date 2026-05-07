using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.Method_Overriding
{
    public class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
}