using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Number_Programs
{
    /*Largest of Three Numbers*/
    public class LargestNumber
    {
        public void FindLargest()
        {
            Console.Write("Enter First Number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Third Number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a >= b && a >= c)
            {
                Console.WriteLine("Largest Number = " + a);
            }
            else if (b >= c)
            {
                Console.WriteLine("Largest Number = " + b);
            }
            else
            {
                Console.WriteLine("Largest Number = " + c);
            }
        }

        public static void Main(string[] args)
        {
            LargestNumber obj = new LargestNumber();
            obj.FindLargest();
        }
    }
}