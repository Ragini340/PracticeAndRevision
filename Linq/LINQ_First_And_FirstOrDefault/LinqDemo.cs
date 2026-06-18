using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Linq.LINQ_First_And_FirstOrDefault
{
    public class LinqDemo
    {
        public void Execute()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            int firstNumber = numbers.First();

            int firstGreaterThan25 = numbers.FirstOrDefault(number => number > 25);

            Console.WriteLine("First : " + firstNumber);
            Console.WriteLine("FirstOrDefault : " + firstGreaterThan25);
        }

        public static void Main(string[] args)
        {
            LinqDemo demo = new LinqDemo();
            demo.Execute();
        }
    }
}