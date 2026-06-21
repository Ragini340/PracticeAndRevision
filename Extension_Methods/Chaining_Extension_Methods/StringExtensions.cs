using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Extension_Methods.Chaining_Extension_Methods
{
    public static class StringExtensions
    {
        public static string ToUpperCase(this string value)
        {
            return value.ToUpper();
        }

        public static string AddPrefix(this string value)
        {
            return "Mr. " + value;
        }

        public static void Main(string[] args)
        {
            string name = "john";

            Console.WriteLine(name.ToUpperCase().AddPrefix());
        }
    }
}