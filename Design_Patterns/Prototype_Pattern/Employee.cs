using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Prototype_Pattern
{
    class Employee : ICloneable
    {
        public string Name { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}