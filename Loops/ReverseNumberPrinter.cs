using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Loops
{
    /*Print Numbers 10 to 1*/
    class ReverseNumberPrinter
    {
        public void PrintNumbers()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Main(string[] args)
        {
            ReverseNumberPrinter obj = new ReverseNumberPrinter();
            obj.PrintNumbers();
        }
    }
}