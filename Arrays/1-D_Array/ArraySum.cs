using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Arrays._1_D_Array
{
    /*Sum of Array Elements*/
    public class ArraySum
    {
        public void CalculateSum()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            int sum = 0;

            foreach (int num in numbers)
            {
                sum += num;
            }

            Console.WriteLine("Sum = " + sum);
        }

        public static void Main(string[] args)
        {
            ArraySum obj = new ArraySum();
            obj.CalculateSum();
        }
    }
}