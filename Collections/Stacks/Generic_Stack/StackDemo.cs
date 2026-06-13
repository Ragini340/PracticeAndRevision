using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Collections.Stacks.Generic_Stack
{
    public class StackDemo
    {
        public void Execute()
        {
            Stack<int> numbers = new Stack<int>();

            numbers.Push(10);
            numbers.Push(20);
            numbers.Push(30);

            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop());
            }
        }

        public static void Main(string[] args)
        {
            StackDemo demo = new StackDemo();
            demo.Execute();
        }
    }
}