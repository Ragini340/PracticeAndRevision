using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Classes_And_Objects.Object_Initializer
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public void Display()
        {
            Console.WriteLine("Student Id : " + StudentId);
            Console.WriteLine("Student Name : " + StudentName);
        }

        public static void Main(string[] args)
        {
            Student student = new Student
            {
                StudentId = 101,
                StudentName = "Raj"
            };

            student.Display();
        }
    }
}