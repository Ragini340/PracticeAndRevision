using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Exception_Handling.System_Exception.FormatExceptions
{
    public class ExceptionDemo
    {
        public void Execute()
        {
            try
            {
                Console.Write("Enter Number : ");

                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(number);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid Number Format");
                Console.WriteLine(ex.Message);
            }
        }

        public static void Main(string[] args)
        {
            ExceptionDemo demo = new ExceptionDemo();
            demo.Execute();
        }
    }
}