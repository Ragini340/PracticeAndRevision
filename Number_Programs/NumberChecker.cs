using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Number_Programs
{
    /*Even or Odd Number*/
    public class NumberChecker
    {
        public void CheckEvenOrOdd()
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }

        public static void Main(string[] args)
        {
            NumberChecker obj = new NumberChecker();
            obj.CheckEvenOrOdd();
        }
    }
}