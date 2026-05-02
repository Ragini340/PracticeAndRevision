using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Arrays._1_D_Array
{
    /*Average of Array Elements*/
    public class ArrayAverage
    {
        public void CalculateAverage()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine("Average = " + average);
        }

        public static void Main(string[] args)
        {
            ArrayAverage obj = new ArrayAverage();
            obj.CalculateAverage();
        }
    }
}