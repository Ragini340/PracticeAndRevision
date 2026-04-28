using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion
{
    public class ConvertDemo
    {
        public void Execute()
        {
            Console.Write("Enter a Number: ");
            string input = Console.ReadLine();

            int number = Convert.ToInt32(input);

            Console.WriteLine("Entered Number = " + number);
        }

        public static void Main(string[] args)
        {
            ConvertDemo obj = new ConvertDemo();
            obj.Execute();
        }
    }
}