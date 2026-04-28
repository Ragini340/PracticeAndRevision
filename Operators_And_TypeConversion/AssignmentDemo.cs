using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion
{
    public class AssignmentDemo
    {
        public void Execute()
        {
            int a = 10;

            a += 5;
            Console.WriteLine("a += 5 : " + a);

            a -= 3;
            Console.WriteLine("a -= 3 : " + a);

            a *= 2;
            Console.WriteLine("a *= 2 : " + a);

            a /= 4;
            Console.WriteLine("a /= 4 : " + a);
        }

        public static void Main(string[] args)
        {
            AssignmentDemo obj = new AssignmentDemo();
            obj.Execute();
        }
    }
}