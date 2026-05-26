using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructor.Default_Constructor
{
    internal class Driver
    {
        static void Main(string[] args)
        {
            Student objstu = new Student();
            objstu.DisplayStudent();
            Student obj = new Student();
            obj.DisplayStudent();
        }
    }
}