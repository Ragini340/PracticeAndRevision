using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Classes_And_Objects.Fields_And_Methods
{
    public class Calculator
    {
        int firstNumber = 10;
        int secondNumber = 20;

        public void Add()
        {
            Console.WriteLine("Sum = " + (firstNumber + secondNumber));
        }

        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.Add();
        }
    }
}