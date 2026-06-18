using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Linq.LINQ_Introduction
{
    public class LinqDemo
    {
        public void Execute()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            var result = from number in numbers select number;

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