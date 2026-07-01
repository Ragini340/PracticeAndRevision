using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Lambda_Expressions.Lambda_with_Find
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            int result = numbers.Find(number => number > 25);

            Console.WriteLine(result);
        }
    }
}