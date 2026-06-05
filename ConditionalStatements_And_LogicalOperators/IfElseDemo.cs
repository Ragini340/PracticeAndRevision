using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion.ConditionalStatements_And_LogicalOperators
{
    public class IfElseDemo
    {
        public void Execute()
        {
            int number = 25;

            if (number % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }

        public static void Main(string[] args)
        {
            IfElseDemo obj = new IfElseDemo();
            obj.Execute();
        }
    }
}