using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Arrays._1_D_Array
{
    /*Sort Array (Ascending Order)*/
    public class SortArray
    {
        public void SortNumbers()
        {
            int[] numbers = { 50, 20, 40, 10, 30 };

            System.Array.Sort(numbers);

            Console.WriteLine("Sorted Array:");

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public static void Main(string[] args)
        {
            SortArray obj = new SortArray();
            obj.SortNumbers();
        }
    }
}