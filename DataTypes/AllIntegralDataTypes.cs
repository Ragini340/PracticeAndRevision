using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.DataTypes
{
    public class AllIntegralDataTypes
    {
        public void Display()
        {
            short s = 100;
            int i = 200;
            long l = 300;
            ushort us = 400;
            uint ui = 500;
            ulong ul = 600;

            Console.WriteLine("short : " + s);
            Console.WriteLine("int   : " + i);
            Console.WriteLine("long  : " + l);
            Console.WriteLine("ushort: " + us);
            Console.WriteLine("uint  : " + ui);
            Console.WriteLine("ulong : " + ul);
        }

        public static void Main(string[] args)
        {
            AllIntegralDataTypes obj = new AllIntegralDataTypes();
            obj.Display();
        }
    }
}