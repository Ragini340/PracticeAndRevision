using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion.ConditionalStatements_And_LogicalOperators
{
    public class LogicalOrDemo
    {
        public void Execute()
        {
            int marks = 35;

            bool result = marks >= 35 || marks >= 75;

            Console.WriteLine("Result = " + result);
        }

        public static void Main(string[] args)
        {
            LogicalOrDemo obj = new LogicalOrDemo();
            obj.Execute();
        }
    }
}