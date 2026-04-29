using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion.ConditionalStatements_And_LogicalOperators
{
    public class LeftShiftDemo
    {
        public void Execute()
        {
            int number = 5;

            Console.WriteLine("Original Value = " + number);
            Console.WriteLine("After Left Shift = " + (number << 1));
        }

        public static void Main(string[] args)
        {
            LeftShiftDemo obj = new LeftShiftDemo();
            obj.Execute();
        }
    }
}