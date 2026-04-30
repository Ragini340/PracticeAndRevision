using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Loops
{
    /*Multiplication Table*/
    public class TableGenerator
    {
        public void GenerateTable()
        {
            Console.Write("Enter Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }

        public static void Main(string[] args)
        {
            TableGenerator obj = new TableGenerator();
            obj.GenerateTable();
        }
    }
}