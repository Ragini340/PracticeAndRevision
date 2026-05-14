using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructors.this_Keyword
{
    public class Calculator
    {
        private int a;
        private int b;

        public Calculator(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Add()
        {
            Console.WriteLine($"Sum = {a + b}");
        }

        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator(10, 20);
            calculator.Add();
        }
    }
}