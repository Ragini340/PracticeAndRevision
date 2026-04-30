using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Loops
{
    public class ForLoopDemo
    {
        public void Execute()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Main(string[] args)
        {
            ForLoopDemo obj = new ForLoopDemo();
            obj.Execute();
        }
    }
}