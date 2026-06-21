using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Extension_Methods.Extension_Method_Returning_Value
{
    public static class StringExtensions
    {
        public static int GetLength(this string value)
        {
            return value.Length;
        }

        public static void Main(string[] args)
        {
            string name = "Extension";

            Console.WriteLine(name.GetLength());
        }
    }
}