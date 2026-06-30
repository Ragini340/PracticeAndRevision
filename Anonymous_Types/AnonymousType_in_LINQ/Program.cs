using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Anonymous_Types.AnonymousType_in_LINQ
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30 };

            var result =
                numbers.Select(number => new
                {
                    Value = number,
                    Square = number * number
                });

            foreach (var item in result)
            {
                Console.WriteLine(item.Value + " : " + item.Square);
            }
        }
    }
}