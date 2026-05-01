using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Number_Programs
{
    /*Palindrome Number*/
    public class PalindromeChecker
    {
        public void CheckPalindrome()
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int original = number;
            int reverse = 0;

            while (number > 0)
            {
                int digit = number % 10;
                reverse = reverse * 10 + digit;
                number /= 10;
            }

            if (original == reverse)
            {
                Console.WriteLine("Palindrome Number");
            }
            else
            {
                Console.WriteLine("Not a Palindrome Number");
            }
        }

        public static void Main(string[] args)
        {
            PalindromeChecker obj = new PalindromeChecker();
            obj.CheckPalindrome();
        }
    }
}