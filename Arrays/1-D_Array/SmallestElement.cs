using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Arrays._1_D_Array
{
    /*Smallest Element in Array*/
    public class SmallestElement
    {
        public void FindSmallest()
        {
            int[] numbers = { 12, 45, 67, 23, 89, 10 };

            int smallest = numbers[0];

            foreach (int num in numbers)
            {
                if (num < smallest)
                {
                    smallest = num;
                }
            }

            Console.WriteLine("Smallest Element = " + smallest);
        }

        public static void Main(string[] args)
        {
            SmallestElement obj = new SmallestElement();
            obj.FindSmallest();
        }
    }
}