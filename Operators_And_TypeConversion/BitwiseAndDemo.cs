using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion
{
    public class BitwiseAndDemo
    {
        public void Execute()
        {
            int a = 2; //0010
            int b = 6; //0110

            int result = a & b;

            Console.WriteLine("Result = " + result);
        }

        public static void Main(string[] args)
        {
            BitwiseAndDemo obj = new BitwiseAndDemo();
            obj.Execute();
        }
    }
}