using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Inheritance.Inheritance_Examples.Student__College_Ex
{
    public class Student : College
    {
        private int studentId = 101;
        private string studentName = "Raj";

        public void Display()
        {
            Console.WriteLine("Student Id : " + studentId);
            Console.WriteLine("Student Name : " + studentName);
            Console.WriteLine("College Name : " + collegeName);
        }
    }
}