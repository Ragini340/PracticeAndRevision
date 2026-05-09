using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Interfaces.Explicit_Interface_Implementation
{
    public class Demo : IFirst, ISecond
    {
        void IFirst.Show()
        {
            Console.WriteLine("IFirst Show");
        }

        void ISecond.Show()
        {
            Console.WriteLine("ISecond Show");
        }
    }
}