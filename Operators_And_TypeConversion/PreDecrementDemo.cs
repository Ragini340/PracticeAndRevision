using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion
{
    public class PreDecrementDemo
    {
        public void Execute()
        {
            int a = 10;

            Console.WriteLine("--a = " + (--a));
        }

        public static void Main(string[] args)
        {
            PreDecrementDemo obj = new PreDecrementDemo();
            obj.Execute();
        }
    }
}