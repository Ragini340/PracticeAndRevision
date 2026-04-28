using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion
{
    public class PreIncrementDemo
    {
        public void Execute()
        {
            int a = 10;

            Console.WriteLine("Before Increment = " + a);

            Console.WriteLine("After ++a = " + (++a));
        }

        public static void Main(string[] args)
        {
            PreIncrementDemo obj = new PreIncrementDemo();
            obj.Execute();
        }
    }
}