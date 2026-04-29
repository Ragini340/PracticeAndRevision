using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion.ConditionalStatements_And_LogicalOperators
{
    public class GradeDemo
    {
        public void Execute()
        {
            int marks = 78;

            if (marks >= 75)
            {
                Console.WriteLine("Grade A");
            }
            else if (marks >= 60)
            {
                Console.WriteLine("Grade B");
            }
            else if (marks >= 50)
            {
                Console.WriteLine("Grade C");
            }
            else if (marks >= 35)
            {
                Console.WriteLine("Grade D");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }

        public static void Main(string[] args)
        {
            GradeDemo obj = new GradeDemo();
            obj.Execute();
        }
    }
}