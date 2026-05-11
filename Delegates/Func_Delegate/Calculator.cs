using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Delegates.Func_Delegate
{
    public class Calculator
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Func<int, int, int> func = calculator.Multiply;

            Console.WriteLine("Result : " + func(10, 20));
        }
    }
}