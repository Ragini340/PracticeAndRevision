using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Liskov_Substitution_Principle
{
    class LSPDemo
    {
        public void Execute()
        {
            Bird bird = new Sparrow();
            bird.Move();

            bird = new Ostrich();
            bird.Move();
        }
    }
}