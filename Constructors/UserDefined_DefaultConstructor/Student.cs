using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructors.UserDefined_DefaultConstructor
{
    public class Student
    {
        private int id;
        private string name;

        public Student()
        {
            id = 101;
            name = "John";
        }

        public void Display()
        {
            Console.WriteLine($"Id : {id}");
            Console.WriteLine($"Name : {name}");
        }

        public static void Main(string[] args)
        {
            Student student = new Student();
            student.Display();
        }
    }
}