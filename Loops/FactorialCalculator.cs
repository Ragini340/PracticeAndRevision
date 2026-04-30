using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Loops
{
    /*Factorial of a Number*/
    public class FactorialCalculator
    {
        public void CalculateFactorial()
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine("Factorial = " + factorial);
        }

        public void Main(string[] args)
        {
            FactorialCalculator obj = new FactorialCalculator();
            obj.CalculateFactorial();
        }
    }
}