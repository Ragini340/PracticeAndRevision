using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Anonymous_Types.AnonymousType_with_MultipleProperties
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var student = new
            {
                RollNo = 1,
                Name = "Ragini",
                Course = "C#",
                Marks = 95
            };

            Console.WriteLine(student.RollNo);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Course);
            Console.WriteLine(student.Marks);
        }
    }
}