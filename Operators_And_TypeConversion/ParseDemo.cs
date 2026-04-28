using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Operators_And_TypeConversion
{
    public class ParseDemo
    {
        public void Execute()
        {
            Console.Write("Enter a Number: ");
            string input = Console.ReadLine();

            int number = int.Parse(input);

            Console.WriteLine("Entered Number = " + number);
        }

        public static void Main(string[] args)
        {
            ParseDemo obj = new ParseDemo();
            obj.Execute();
        }
    }
}