using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Interfaces.Simple_Interface
{
    public class Message : IMessage
    {
        public void Display()
        {
            Console.WriteLine("Interface Method Called");
        }
    }
}