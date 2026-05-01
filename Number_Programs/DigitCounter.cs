using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Number_Programs
{
    /*Count Digits*/
    public class DigitCounter
    {
        public void Count()
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            while (number > 0)
            {
                count++;
                number /= 10;
            }

            Console.WriteLine("Number Of Digits = " + count);
        }

        public static void Main(string[] args)
        {
            DigitCounter obj = new DigitCounter();
            obj.Count();
        }
    }
}