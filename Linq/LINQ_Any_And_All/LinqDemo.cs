using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Linq.LINQ_Any_And_All
{
    public class LinqDemo
    {
        public void Execute()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            bool any = numbers.Any(number => number > 40);

            bool all = numbers.All(number => number > 5);

            Console.WriteLine("Any : " + any);
            Console.WriteLine("All : " + all);
        }

        public static void Main(string[] args)
        {
            LinqDemo demo = new LinqDemo();
            demo.Execute();
        }
    }
}