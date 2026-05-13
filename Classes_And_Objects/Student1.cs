using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Classes_And_Objects
{
    public class Student1
    {
        int studentId = 101;
        string studentName = "Raj";

        public void DisplayStudent()
        {
            Console.WriteLine("Student Id : " + studentId);
            Console.WriteLine("Student Name : " + studentName);
        }

        public static void Main(string[] args)
        {
            Student1 student1 = new Student1();
            student1.DisplayStudent();
        }
    }
}