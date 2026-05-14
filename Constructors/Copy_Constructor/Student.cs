using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructors.Copy_Constructor
{
    public class Student
    {
        public string Name;
        public int Age;

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Student(Student student)
        {
            Name = student.Name;
            Age = student.Age;
        }

        public void Display()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Age : {Age}");
        }

        public static void Main(string[] args)
        {
            Student original = new Student("Ram", 22);
            Student copy = new Student(original);

            copy.Display();
        }
    }
}