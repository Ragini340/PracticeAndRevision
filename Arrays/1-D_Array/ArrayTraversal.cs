using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Arrays._1_D_Array
{
    public class ArrayTraversal
    {
        public void Display()
        {
            int[] numbers = { 5, 10, 15, 20, 25 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Element at Index {i} = {numbers[i]}");
            }
        }

        public static void Main(string[] args)
        {
            ArrayTraversal obj = new ArrayTraversal();
            obj.Display();
        }
    }
}