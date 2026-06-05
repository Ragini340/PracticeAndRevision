using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.DataTypes
{
    public class FloatingDemo
    {
        public void Display()
        {
            float f = 10.25f;
            double d = 20.56789;
            decimal m = 100.75m;

            Console.WriteLine("Float   : " + f);
            Console.WriteLine("Double  : " + d);
            Console.WriteLine("Decimal : " + m);
        }

        public static void Main(string[] args)
        {
            FloatingDemo obj = new FloatingDemo();
            obj.Display();
        }
    }
}