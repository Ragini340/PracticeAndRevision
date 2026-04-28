using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion
{
    public class PostDecrementDemo
    {
        public void Execute()
        {
            int a = 10;

            Console.WriteLine("a-- = " + (a--));
            Console.WriteLine("Current Value = " + a);
        }

        public static void Main(string[] args)
        {
            PostDecrementDemo obj = new PostDecrementDemo();
            obj.Execute();
        }
    }
}