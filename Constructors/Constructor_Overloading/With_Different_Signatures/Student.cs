using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructors.Constructor_Overloading.With_Different_Signatures
{
    public class Student
    {
        private int id;
        private string name;

        public Student()
        {
            id = 0;
            name = "Unknown";
        }

        public Student(int id)
        {
            this.id = id;
            name = "Not Provided";
        }

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
            Student student1 = new Student();
            student1.Display();

            Student student2 = new Student(101);
            student2.Display();

            Student student3 = new Student(102, "John");
            student3.Display();
        }

    }
}