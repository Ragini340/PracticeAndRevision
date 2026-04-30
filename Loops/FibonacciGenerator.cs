using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Loops
{
    /*Fibonacci Series*/
    public class FibonacciGenerator
    {
        public void GenerateSeries()
        {
            Console.Write("Enter Number of Terms: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int first = 0;
            int second = 1;

            Console.Write(first + " " + second + " ");

            for (int i = 3; i <= n; i++)
            {
                int third = first + second;

                Console.Write(third + " ");

                first = second;
                second = third;
            }
        }

        public static void Main(string[] args)
        {
            FibonacciGenerator obj = new FibonacciGenerator();
            obj.GenerateSeries();
        }
    }
}