using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Delegates.Delegate_with_ReturnType
{
    public delegate int AddDelegate(int a, int b);

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            AddDelegate del = calculator.Add;

            int result = del(10, 20);

            Console.WriteLine("Result : " + result);
        }
    }
}