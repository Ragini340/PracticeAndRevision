using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Methods.Method_Returning
{
    /*Method Returning Largest Number*/
    public class LargestFinder
    {
        public int GetLargest(int a, int b)
        {
            return a > b ? a : b;
        }

        public static void Main(string[] args)
        {
            LargestFinder obj = new LargestFinder();

            int result = obj.GetLargest(50, 25);

            Console.WriteLine("Largest Number = " + result);
        }
    }
}