using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Extension_Methods.Extension_Method_for_Integer
{
    public static class IntegerExtensions
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0;
        }

        public static void Main(string[] args)
        {
            int number = 10;

            Console.WriteLine(number.IsEven());
        }
    }
}