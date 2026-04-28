using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion
{
    public class ArithmeticDemo
    {
        public void Calculate()
        {
            int a = 20;
            int b = 10;

            Console.WriteLine("Addition = " + (a + b));
            Console.WriteLine("Subtraction = " + (a - b));
            Console.WriteLine("Multiplication = " + (a * b));
            Console.WriteLine("Division = " + (a / b));
            Console.WriteLine("Modulus = " + (a % b));
        }

        public static void Main(string[] args)
        {
            ArithmeticDemo obj = new ArithmeticDemo();
            obj.Calculate();
        }
    }
}