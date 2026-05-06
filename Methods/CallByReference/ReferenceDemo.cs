using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Methods.CallByReference
{
    public class ReferenceDemo
    {
        public void ChangeValue(ref int number)
        {
            number = number + 100;

            Console.WriteLine("Inside Method = " + number);
        }

        public static void Main(string[] args)
        {
            int number = 50;

            ReferenceDemo obj = new ReferenceDemo();

            obj.ChangeValue(ref number);

            Console.WriteLine("Outside Method = " + number);
        }
    }
}