using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Number_Programs
{
    /*Reverse a Number*/
    public class ReverseNumber
    {
        public void Reverse()
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int reverse = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number /= 10;
            }

            Console.WriteLine("Reverse Number = " + reverse);
        }

        public static void Main(string[] args)
        {
            ReverseNumber obj = new ReverseNumber();
            obj.Reverse();
        }
    }
}