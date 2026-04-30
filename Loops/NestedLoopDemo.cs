using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Loops
{
    public class NestedLoopDemo
    {
        public void DisplayPattern()
        {
            for (int row = 1; row <= 5; row++)
            {
                for (int col = 1; col <= 5; col++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            NestedLoopDemo obj = new NestedLoopDemo();
            obj.DisplayPattern();
        }
    }
}