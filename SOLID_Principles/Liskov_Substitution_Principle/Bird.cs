using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Liskov_Substitution_Principle
{
    class Bird
    {
        public virtual void Move()
        {
            Console.WriteLine("Bird is Moving");
        }
    }
}