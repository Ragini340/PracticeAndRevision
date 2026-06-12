using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Exception_Handling.Multiple_Catch_Blocks
{
    public class ExceptionDemo
    {
        public void Execute()
        {
            try
            {
                int number = Convert.ToInt32("ABC");

                int[] values = { 10, 20, 30 };

                Console.WriteLine(values[5]);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index Out Of Range Exception");
            }
            catch (Exception)
            {
                Console.WriteLine("General Exception");
            }
        }

        public static void Main(string[] args)
        {
            ExceptionDemo demo = new ExceptionDemo();
            demo.Execute();
        }
    }
}