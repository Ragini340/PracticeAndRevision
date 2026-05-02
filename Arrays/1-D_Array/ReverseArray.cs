using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Arrays._1_D_Array
{
    public class ReverseArray
    {
        public void DisplayReverse()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine("Array Elements In Reverse Order:");

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void Main(string[] args)
        {
            ReverseArray obj = new ReverseArray();
            obj.DisplayReverse();
        }
    }
}