using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Inheritance.MethodReuse_Through_Inheritance
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            AdvancedCalculator calculator = new AdvancedCalculator();

            Console.WriteLine("Sum = " + calculator.Add(10, 20));
            Console.WriteLine("Product = " + calculator.Multiply(10, 20));
        }
    }
}