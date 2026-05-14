using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructors.Parameterized_Constructor
{
    public class Student
    {
        private int id;
        private string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine($"Id : {id}");
            Console.WriteLine($"Name : {name}");
        }

        public static void Main(string[] args)
        {
            Student student = new Student(101, "Ram");
            student.Display();
        }
    }
}