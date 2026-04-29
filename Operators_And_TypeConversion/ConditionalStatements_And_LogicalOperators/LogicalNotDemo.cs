using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion.ConditionalStatements_And_LogicalOperators
{
    public class LogicalNotDemo
    {
        public void Execute()
        {
            bool isHoliday = false;

            Console.WriteLine("Holiday Status = " + isHoliday);
            Console.WriteLine("After NOT = " + !isHoliday);
        }

        public static void Main(string[] args)
        {
            LogicalNotDemo obj = new LogicalNotDemo();
            obj.Execute();
        }
    }
}