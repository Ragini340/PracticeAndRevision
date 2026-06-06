using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Access_Modifiers.Private_Protected
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Child child = new Child();
            child.ChildDisplay();
        }
    }
}