using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion
{
    public class RelationalDemo
    {
        public void Compare()
        {
            int a = 20;
            int b = 10;

            Console.WriteLine("a > b  : " + (a > b));
            Console.WriteLine("a < b  : " + (a < b));
            Console.WriteLine("a >= b : " + (a >= b));
            Console.WriteLine("a <= b : " + (a <= b));
            Console.WriteLine("a == b : " + (a == b));
            Console.WriteLine("a != b : " + (a != b));
        }

        public static void Main(string[] args)
        {
            RelationalDemo obj = new RelationalDemo();
            obj.Compare();
        }
    }
}