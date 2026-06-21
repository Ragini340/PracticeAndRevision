using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Extension_Methods.Multiple_Extension_Methods
{
    public static class StringExtensions
    {
        public static string ToUpperCase(this string value)
        {
            return value.ToUpper();
        }

        public static string ToLowerCase(this string value)
        {
            return value.ToLower();
        }

        public static void Main(string[] args)
        {
            string name = "John";

            Console.WriteLine(name.ToUpperCase());
            Console.WriteLine(name.ToLowerCase());
        }
    }
}