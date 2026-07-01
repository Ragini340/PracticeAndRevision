using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Lambda_Expressions.Lambda_with_Any
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            bool result = numbers.Any(number => number > 45);

            Console.WriteLine(result);
        }
    }
}