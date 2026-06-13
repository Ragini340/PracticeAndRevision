using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Collections.Stacks
{
    public class StackDemo
    {
        public void Execute()
        {
            Stack stack = new Stack();

            stack.Push("A");
            stack.Push("B");
            stack.Push("C");

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        public static void Main(string[] args)
        {
            StackDemo demo = new StackDemo();
            demo.Execute();
        }
    }
}