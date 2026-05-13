using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Classes_And_Objects.Static_Variable
{
    public class Counter
    {
        public static int Count = 0;

        public Counter()
        {
            Count++;
        }

        public static void DisplayCount()
        {
            Console.WriteLine("Object Count = " + Count);
        }

        public static void Main(string[] args)
        {
            Counter counter1 = new Counter();
            Counter counter2 = new Counter();
            Counter counter3 = new Counter();

            Counter.DisplayCount();
        }
    }
}