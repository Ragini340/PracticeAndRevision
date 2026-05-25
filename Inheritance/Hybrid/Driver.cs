using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Inheritance.Hybrid
{
    /*Hybrid Inheritance:
    Hybrid is a combination of two types of inheritance that is single as well as Hierarchical inheritance.
    */
    internal class Driver
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Study();

            s.Display();
            Teacher t = new Teacher();
            t.Teach();
            t.Display();
        }
    }
}