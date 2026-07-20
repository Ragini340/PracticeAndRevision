using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Liskov_Substitution_Principle
{
    class Ostrich : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Ostrich is Running");
        }
    }
}