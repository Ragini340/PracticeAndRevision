using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Miscellaneous
{
    // Time Complexity: O(log n)
    // The loop runs once for each digit in the number.
    // The number of digits in n is proportional to log10(n),
    // therefore the time complexity is O(log n).

    // Space Complexity: O(1)
    // because only constant extra variables are used.
    public class ArmstorngNumber
    {
        public static void ArmstrongNum(int num)
        {
            int temp = num;
            int sum = 0;

            while (num > 0)
            {
                int rem = num % 10;
                int cube = rem * rem * rem;

                sum += cube;

                num = num / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("Entered number is an Armstrong number.");
            }
            else
            {
                Console.WriteLine("Entered number is not an Armstrong number.");
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            ArmstrongNum(num);
        }
    }
}