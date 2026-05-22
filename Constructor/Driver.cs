using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeAndRevision.Destructor;

namespace PracticeAndRevision.Constructor
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            StaticConstructor obj = new StaticConstructor(101, "John", 22);
            StaticConstructor obj1 = new StaticConstructor(102, "RAM", 26);
            StaticConstructor.DisplayCollege();
            obj.DisplayStudent();
            obj.DisplayStudent();
        }
    }
}