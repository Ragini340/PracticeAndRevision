using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Access_Modifier.Internal
{
    internal class MyClass
    {
        internal int a = 10;
        public void MyMethod()
        {
            Console.WriteLine("value of a is " + a);
        }
    }
}
