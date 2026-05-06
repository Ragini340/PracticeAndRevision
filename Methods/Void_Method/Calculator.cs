using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Methods.Void_Method
{
    public class Calculator
    {
        public void AddNumbers()
        {
            int a = 10;
            int b = 20;

            Console.WriteLine("Sum = " + (a + b));
        }

        public static void Main(string[] args)
        {
            Calculator obj = new Calculator();
            obj.AddNumbers();
        }
    }
}