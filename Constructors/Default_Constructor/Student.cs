using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructors.Default_Constructor
{
    public class Student
    {
        public Student()
        {
            Console.WriteLine("Default Constructor Called");
        }

        public static void Main(string[] args)
        {
            Student student = new Student();
        }
    }
}