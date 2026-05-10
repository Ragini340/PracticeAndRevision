using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Generic_Collections.Lists.Methods.Find
{
    public class ListDemo
    {
        public void Execute()
        {
            List<int> numbers = new List<int>()
            {
                10,20,30,40,50
            };

            int result = numbers.Find(number => number > 25);

            Console.WriteLine("Found : " + result);
        }

        public static void Main(string[] args)
        {
            ListDemo demo = new ListDemo();
            demo.Execute();
        }
    }
}