using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Arrays._1_D_Array
{
    /*One Dimensional Array*/
    public class ArrayDemo
    {
        public void Display()
        {
            int[] numbers = new int[5];

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void Main(string[] args)
        {
            ArrayDemo obj = new ArrayDemo();
            obj.Display();
        }
    }
}