using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Array
{
    /*
     Time Complexity  : O(n)
     Space Complexity : O(n)
    */
    public class StudentMarks
    {
        string[] studentNames = new string[5];
        int[] marks = new int[5];

        public void GetStudentDetails()
        {
            Console.WriteLine("===== Student Details Entry =====\n");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"Student {i + 1}");

                Console.Write("Enter Student Name : ");
                studentNames[i] = Console.ReadLine();

                Console.Write("Enter Marks        : ");
                marks[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
            }
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("\n===== Student Marks Report =====\n");

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("S.No\tName\t\tMarks");
            Console.WriteLine("-----------------------------------");

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine($"{i + 1}\t{studentNames[i]}\t\t{marks[i]}");
            }

            Console.WriteLine("-----------------------------------");
        }

        public static void Main(string[] args)
        {
            StudentMarks obj = new StudentMarks();

            obj.GetStudentDetails();
            obj.DisplayStudentDetails();

            Console.ReadKey();
        }
    }
}