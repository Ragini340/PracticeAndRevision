using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Linq.LINQ_OrderByDescending
{
    public class LinqDemo
    {
        public void Execute()
        {
            int[] numbers = { 50, 20, 10, 40, 30 };

            var result = numbers.OrderByDescending(number => number);

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }

        public static void Main(string[] args)
        {
            LinqDemo demo = new LinqDemo();
            demo.Execute();
        }
    }
}