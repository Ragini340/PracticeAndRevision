using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Array
{
    public class StudentMarks
    {
        int[] marks = new int[5];

        public void GetMarks()
        {
            Console.WriteLine("Enter 5 student marks:");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Enter mark " + (i + 1) + ": ");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayMarks()
        {
            Console.WriteLine("\nStudent Marks:");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine("Mark " + (i + 1) + ": " + marks[i]);
            }
        }

        public static void Main(string[]args)
        {
            StudentMarks obj = new StudentMarks();

            obj.GetMarks();
            obj.DisplayMarks();
        }
    }
}