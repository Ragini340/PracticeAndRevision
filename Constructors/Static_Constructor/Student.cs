using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructors.Static_Constructor
{
    public class Student
    {
        static string College;

        static Student()
        {
            College = "ABC College";
        }
    }
}