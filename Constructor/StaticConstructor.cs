using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructor
{
    public class StaticConstructor
    {
        int sid;
        string sname;
        int age;
        static string college;
        public StaticConstructor(int Sid, string Sname, int Age)
        {
            sid = Sid;
            sname = Sname;
            age = Age;
        }
        static StaticConstructor()
        {
            college = "ABC";
        }
        public void DisplayStudent()
        {
            Console.WriteLine($"Student is {sid}");
            Console.WriteLine($"Student name is {sname}");
            Console.WriteLine($"Student Age is " + age);
        }
        public static void DisplayCollege()
        {
            Console.WriteLine("College name is " + college);
        }
    }
}