using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Loops
{
    public class WhileLoopDemo
    {
        public void Execute()
        {
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void Main(string[] args)
        {
            WhileLoopDemo obj = new WhileLoopDemo();
            obj.Execute();
        }
    }
}