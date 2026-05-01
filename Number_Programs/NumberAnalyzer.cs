using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Number_Programs
{
    /*Positive, Negative or Zero*/
    public class NumberAnalyzer
    {
        public void Analyze()
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }

        public static void Main(string[] args)
        {
            NumberAnalyzer obj = new NumberAnalyzer();
            obj.Analyze();
        }
    }
}