using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Classes_And_Objects
{
    public class Student
    {
        public void Display()
        {
            Console.WriteLine("Student Object Created");
        }

        public static void Main(string[] args)
        {
            Student student = new Student();
            student.Display();
        }
    }
}