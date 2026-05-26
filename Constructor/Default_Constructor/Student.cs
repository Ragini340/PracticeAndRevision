using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructor.Default_Constructor
{
    class Student
    {
        //UserDefinedDefaultConstructor: it a paramter less constructor.
        int sid;
        string sname;
        double sfee;
        public Student()
        {
            sid = 1;
            sname = "ABC";
            sfee = 25000;
        }
        public void DisplayStudent()
        {
            Console.WriteLine("Student id is " + sid);

            Console.WriteLine("Student name is " + sname);
            Console.WriteLine("Student fee is " + sfee);
        }
    }
}