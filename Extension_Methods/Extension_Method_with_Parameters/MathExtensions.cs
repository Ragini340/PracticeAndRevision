using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Extension_Methods.Extension_Method_with_Parameters
{
    public static class MathExtensions
    {
        public static int Multiply(this int number, int value)
        {
            return number * value;
        }

        public static void Main(string[] args)
        {
            int number = 10;

            Console.WriteLine(number.Multiply(5));
        }
    }
}