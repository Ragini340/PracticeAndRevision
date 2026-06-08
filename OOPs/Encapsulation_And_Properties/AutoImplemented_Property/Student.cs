using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Encapsulation_And_Properties.AutoImplemented_Property
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public static void Main(string[] args)
        {
            Student student = new Student();

            student.StudentId = 101;
            student.StudentName = "Raj";

            Console.WriteLine("Student Id : " + student.StudentId);
            Console.WriteLine("Student Name : " + student.StudentName);
        }
    }
}