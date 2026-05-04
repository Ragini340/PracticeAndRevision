using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Arrays._2_D_Array
{
    public class TwoDimensionalArray
    {
        public void Display()
        {
            int[,] numbers =
            {
                { 10, 20, 30 },
                { 40, 50, 60 }
            };

            for (int row = 0; row < numbers.GetLength(0); row++)
            {
                for (int col = 0; col < numbers.GetLength(1); col++)
                {
                    Console.Write(numbers[row, col] + "\t");
                }

                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            TwoDimensionalArray obj = new TwoDimensionalArray();
            obj.Display();
        }
    }
}