using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Encapsulation_And_Properties.Getter_Setter_Methods
{
    public class Student
    {
        private int studentId;

        public void SetStudentId(int id)
        {
            studentId = id;
        }

        public int GetStudentId()
        {
            return studentId;
        }

        public static void Main(string[] args)
        {
            Student student = new Student();

            student.SetStudentId(101);

            Console.WriteLine("Student Id : " + student.GetStudentId());
        }
    }
}