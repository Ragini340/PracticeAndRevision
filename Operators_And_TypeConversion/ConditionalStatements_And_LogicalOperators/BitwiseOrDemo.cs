using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion.ConditionalStatements_And_LogicalOperators
{
    public class BitwiseOrDemo
    {
        public void Execute()
        {
            int a = 2; //0010
            int b = 6; //0110

            int result = a | b;

            Console.WriteLine("Result = " + result);
        }

        public static void Main(string[] args)
        {
            BitwiseOrDemo obj = new BitwiseOrDemo();
            obj.Execute();
        }
    }
}