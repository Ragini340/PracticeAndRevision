using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Loops
{
    /*Sum of First N Numbers*/
    public class SumCalculator
    {
        public void CalculateSum()
        {
            Console.Write("Enter N Value: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }

            Console.WriteLine("Sum = " + sum);
        }

        public static void Main(string[] args)
        {
            SumCalculator obj = new SumCalculator();
            obj.CalculateSum();
        }
    }
}