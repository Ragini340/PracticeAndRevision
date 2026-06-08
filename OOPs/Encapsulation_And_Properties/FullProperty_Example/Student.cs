using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Encapsulation_And_Properties.FullProperty_Example
{
    public class Student
    {
        private int studentId;

        public int StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
            }
        }

        public static void Main(string[] args)
        {
            Student student = new Student();

            student.StudentId = 101;

            Console.WriteLine("Student Id : " + student.StudentId);
        }
    }
}