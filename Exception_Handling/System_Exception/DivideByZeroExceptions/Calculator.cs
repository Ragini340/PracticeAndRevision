using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Exception_Handling.System_Exception.DivideByZeroExceptions
{
    public class Calculator
    {
        public void Divide()
        {
            try
            {
                int number1 = 100;
                int number2 = 0;

                int result = number1 / number2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot Divide By Zero");
                Console.WriteLine(ex.Message);
            }
        }

        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Divide();
        }
    }
}