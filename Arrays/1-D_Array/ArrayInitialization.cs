using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Arrays._1_D_Array
{
    public class ArrayInitialization
    {
        public void Display()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }

        public static void Main(string[] args)
        {
            ArrayInitialization obj = new ArrayInitialization();
            obj.Display();
        }
    }
}