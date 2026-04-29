using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion.ConditionalStatements_And_LogicalOperators
{
    public class TernaryDemo
    {
        public void Execute()
        {
            int number = 15;

            string result = number % 2 == 0
                ? "Even Number"
                : "Odd Number";

            Console.WriteLine(result);
        }

        public static void Main(string[] args)
        {
            TernaryDemo obj = new TernaryDemo();
            obj.Execute();
        }
    }
}