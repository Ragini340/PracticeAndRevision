using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Loops
{
    /*Print Numbers 10 to 1*/
    public class NumberPrinter
    {
        public void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Main(string[] args)
        {
            NumberPrinter obj = new NumberPrinter();
            obj.PrintNumbers();
        }
    }
}