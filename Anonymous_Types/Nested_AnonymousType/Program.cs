using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Anonymous_Types.Nested_AnonymousType
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var student = new
            {
                Name = "Ragini",
                Marks = new int[] { 90, 85, 95 }
            };

            Console.WriteLine(student.Name);

            foreach (int mark in student.Marks)
            {
                Console.WriteLine(mark);
            }
        }
    }
}