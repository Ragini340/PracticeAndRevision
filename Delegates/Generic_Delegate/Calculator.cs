using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Delegates.Generic_Delegate
{
    public delegate T OperationDelegate<T>(T value1, T value2);

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            OperationDelegate<int> del = calculator.Add;

            Console.WriteLine(del(10, 20));
        }
    }
}