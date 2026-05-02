using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Arrays._1_D_Array
{
    /*Largest Element in Array*/
    public class LargestElement
    {
        public void FindLargest()
        {
            int[] numbers = { 12, 45, 67, 23, 89, 10 };

            int largest = numbers[0];

            foreach (int num in numbers)
            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            Console.WriteLine("Largest Element = " + largest);
        }

        public static void Main(string[] args)
        {
            LargestElement obj = new LargestElement();
            obj.FindLargest();
        }
    }
}