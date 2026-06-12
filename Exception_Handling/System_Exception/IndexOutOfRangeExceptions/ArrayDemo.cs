using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Exception_Handling.System_Exception.IndexOutOfRangeExceptions
{
    public class ArrayDemo
    {
        public void Execute()
        {
            try
            {
                int[] numbers = { 10, 20, 30 };

                Console.WriteLine(numbers[5]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Invalid Array Index");
                Console.WriteLine(ex.Message);
            }
        }

        public static void Main(string[] args)
        {
            ArrayDemo demo = new ArrayDemo();
            demo.Execute();
        }
    }
}