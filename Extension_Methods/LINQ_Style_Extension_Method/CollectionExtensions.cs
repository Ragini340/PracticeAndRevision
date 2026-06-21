using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Extension_Methods.LINQ_Style_Extension_Method
{
    public static class CollectionExtensions
    {
        public static int CountItems<T>(this IEnumerable<T> items)
        {
            int count = 0;

            foreach (T item in items)
            {
                count++;
            }

            return count;
        }

        public static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40 };

            Console.WriteLine(numbers.CountItems());
        }
    }
}