using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Methods.CallByValue
{
    public class ValueDemo
    {
        public void ChangeValue(int number)
        {
            number = number + 100;

            Console.WriteLine("Inside Method = " + number);
        }

        public static void Main(string[] args)
        {
            int number = 50;

            ValueDemo obj = new ValueDemo();

            obj.ChangeValue(number);

            Console.WriteLine("Outside Method = " + number);
        }
    }
}