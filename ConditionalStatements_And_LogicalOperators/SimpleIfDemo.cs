using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion.ConditionalStatements_And_LogicalOperators
{
    public class SimpleIfDemo
    {
        public void Execute()
        {
            int age = 20;

            if (age >= 18)
            {
                Console.WriteLine("Eligible For Voting");
            }
        }

        public static void Main(string[] args)
        {
            SimpleIfDemo obj = new SimpleIfDemo();
            obj.Execute();
        }
    }
}