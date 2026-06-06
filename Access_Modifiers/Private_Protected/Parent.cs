using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Access_Modifiers.Private_Protected
{
    public class Parent
    {
        private protected void Display()
        {
            Console.WriteLine("Private Protected Method Called");
        }

        public void Show()
        {
            Display();
        }
    }
}