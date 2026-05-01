using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Number_Programs
{
    /*Prime Numbers Between 1 and N*/
    public class PrimeSeries
    {
        public void DisplayPrimes()
        {
            Console.Write("Enter N Value: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime Numbers:");

            for (int num = 2; num <= n; num++)
            {
                bool isPrime = true;

                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(num + " ");
                }
            }
        }

        public static void Main(string[] args)
        {
            PrimeSeries obj = new PrimeSeries();
            obj.DisplayPrimes();
        }
    }
}