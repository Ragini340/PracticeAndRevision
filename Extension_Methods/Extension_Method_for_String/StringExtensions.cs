using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Extension_Methods.Extension_Method_for_String
{
    public static class StringExtensions
    {
        public static string ToUpperCase(this string value)
        {
            return value.ToUpper();
        }

        public static void Main(string[] args)
        {
            string name = "john";

            Console.WriteLine(name.ToUpperCase());
        }
    }
}