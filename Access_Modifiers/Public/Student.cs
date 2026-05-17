using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Access_Modifiers.Public
{
    public class Student
    {
        public int Age = 22;

        public void Display()
        {
            Console.WriteLine($"Student Age : {Age}");
        }

        public static void Main(string[] args)
        {
            Student student = new Student();
            student.Display();

            Console.WriteLine($"Accessing Public Variable : {student.Age}");
        }

    }
}