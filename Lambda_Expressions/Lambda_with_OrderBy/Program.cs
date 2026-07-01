using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Lambda_Expressions.Lambda_with_OrderBy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 50, 30, 10, 40, 20 };

            var result = numbers.OrderBy(number => number);

            foreach (int number in result)
            {
                Console.WriteLine(number);
            }
        }
    }
}