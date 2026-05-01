using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Number_Programs
{
    /*Sum of Digits*/
    public class DigitSum
    {
        public void CalculateSum()
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            Console.WriteLine("Sum Of Digits = " + sum);
        }

        public static void Main(string[] args)
        {
            DigitSum obj = new DigitSum();
            obj.CalculateSum();
        }
    }
}