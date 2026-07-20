using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Liskov_Substitution_Principle
{
    class Sparrow : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Sparrow is Flying");
        }
    }
}