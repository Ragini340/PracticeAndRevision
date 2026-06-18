using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Linq.LINQ_Single_And_SingleOrDefault
{
    public class LinqDemo
    {
        public void Execute()
        {
            int[] numbers = { 10 };

            int singleValue = numbers.Single();

            int singleOrDefaultValue = numbers.SingleOrDefault();

            Console.WriteLine("Single : " + singleValue);
            Console.WriteLine("SingleOrDefault : " + singleOrDefaultValue);
        }

        public static void Main(string[] args)
        {
            LinqDemo demo = new LinqDemo();
            demo.Execute();
        }
    }
}