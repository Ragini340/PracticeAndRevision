using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Number_Programs
{
    /*Armstrong Number*/
    public class ArmstrongChecker
    {
        public void CheckArmstrong()
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int original = number;
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += digit * digit * digit;
                number /= 10;
            }

            if (original == sum)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not an Armstrong Number");
            }
        }

        public static void Main(string[] args)
        {
            ArmstrongChecker obj = new ArmstrongChecker();
            obj.CheckArmstrong();
        }
    }
}