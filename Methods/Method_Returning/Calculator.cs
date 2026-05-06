using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Methods.Method_Returning
{
    /*Method Returning Sum*/
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public static void Main(string[] args)
        {
            Calculator obj = new Calculator();

            int result = obj.Add(10, 20);

            Console.WriteLine("Sum = " + result);
        }
    }
}