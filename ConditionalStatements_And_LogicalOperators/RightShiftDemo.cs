using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion.ConditionalStatements_And_LogicalOperators
{
    public class RightShiftDemo
    {
        public void Execute()
        {
            int number = 20;

            Console.WriteLine("Original Value = " + number);
            Console.WriteLine("After Right Shift = " + (number >> 1));
        }

        public static void Main(string[] args)
        {
            RightShiftDemo obj = new RightShiftDemo();
            obj.Execute();
        }
    }
}