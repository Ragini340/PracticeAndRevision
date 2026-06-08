using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Encapsulation_And_Properties.Setter_Method
{
    public class Student
    {
        private string studentName;

        public void SetStudentName(string name)
        {
            studentName = name;
        }

        public void Display()
        {
            Console.WriteLine("Student Name : " + studentName);
        }

        public static void Main(string[] args)
        {
            Student student = new Student();

            student.SetStudentName("Raj");
            student.Display();
        }
    }
}