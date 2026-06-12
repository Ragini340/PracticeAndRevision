using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Exception_Handling.Finally_Block
{
    public class ExceptionDemo
    {
        public void Execute()
        {
            try
            {
                int number1 = 10;
                int number2 = 0;

                int result = number1 / number2;

                Console.WriteLine(result);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Handled");
            }
            finally
            {
                Console.WriteLine("Finally Block Executed");
            }
        }

        public static void Main(string[] args)
        {
            ExceptionDemo demo = new ExceptionDemo();
            demo.Execute();
        }
    }
}