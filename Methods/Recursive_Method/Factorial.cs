using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Methods.Recursive_Method
{
    public class Factorial
    {
        public int Calculate(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }

            return number * Calculate(number - 1);
        }

        public static void Main(string[] args)
        {
            Factorial obj = new Factorial();

            int result = obj.Calculate(5);

            Console.WriteLine("Factorial = " + result);
        }
    }
}