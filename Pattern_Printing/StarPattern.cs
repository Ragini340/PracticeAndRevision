using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Pattern_Printing
{
    /*Write a C# program to print a right-angle triangle star (*) pattern using nested for loops.
*
**
***
****
*****
******
*******
********
*********
**********
***********
     */

    public class StarPattern
    {
        public static void PrintPattern()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            PrintPattern();
        }
    }
}