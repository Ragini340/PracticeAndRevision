using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Design_Patterns.Abstract_Factory_Pattern
{
    public class WindowsButton : IButton
    {
        public void Draw()
        {
            Console.WriteLine("Windows Button");
        }
    }
}