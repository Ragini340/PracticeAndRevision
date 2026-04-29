using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion.ConditionalStatements_And_LogicalOperators
{
    public class LogicalAndDemo
    {
        public void Execute()
        {
            int age = 25;

            bool result = age > 18 && age < 60;

            Console.WriteLine("Eligible = " + result);
        }

        public static void Main(string[] args)
        {
            LogicalAndDemo obj = new LogicalAndDemo();
            obj.Execute();
        }
    }
}