using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Encapsulation_And_Properties.Getter_Method
{
    public class Student
    {
        private string studentName = "Raj";

        public string GetStudentName()
        {
            return studentName;
        }

        public static void Main(string[] args)
        {
            Student student = new Student();

            Console.WriteLine(student.GetStudentName());
        }
    }
}