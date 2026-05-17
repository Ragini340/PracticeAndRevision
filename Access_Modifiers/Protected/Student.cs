using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Access_Modifiers.Protected
{
    public class Student : Person
    {
        public void Display()
        {
            Console.WriteLine($"Age : {Age}");
        }
    }
}