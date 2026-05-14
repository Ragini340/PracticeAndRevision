using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructors.With_Array_of_Objects
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
            Console.WriteLine($"{id} - {name}");
        }

        public static void Main(string[] args)
        {
            Student[] students =
            {
                new Student(101,"Ram"),
                new Student(102,"Shyam"),
                new Student(103,"John")
            };

            foreach (Student student in students)
            {
                student.Display();
            }
        }
    }
}