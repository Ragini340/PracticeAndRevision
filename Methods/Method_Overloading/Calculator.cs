using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Methods.Method_Overloading
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static void Main(string[] args)
        {
            Calculator obj = new Calculator();

            Console.WriteLine("Two Numbers Sum = " + obj.Add(10, 20));

            Console.WriteLine("Three Numbers Sum = " + obj.Add(10, 20, 30));
        }
    }
}