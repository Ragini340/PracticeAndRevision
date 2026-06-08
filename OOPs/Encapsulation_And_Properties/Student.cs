using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Encapsulation_And_Properties
{
    public class Student
    {
        private int studentId;
        private string studentName;

        public void SetData(int id, string name)
        {
            studentId = id;
            studentName = name;
        }

        public void DisplayData()
        {
            Console.WriteLine("Student Id : " + studentId);
            Console.WriteLine("Student Name : " + studentName);
        }

        public static void Main(string[] args)
        {
            Student student = new Student();

            student.SetData(101, "Raj");
            student.DisplayData();
        }
    }
}