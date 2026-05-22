using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Destructor
{
    public class Student
    {
        public Student()
        {
            Console.WriteLine("Constructor Student object created");
        }
        ~Student()
        {
            Console.WriteLine("Destructor Student object destroyed");
        }
    }
}