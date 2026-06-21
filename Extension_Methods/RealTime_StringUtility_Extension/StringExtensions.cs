using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Extension_Methods.RealTime_StringUtility_Extension
{
    public static class StringExtensions
    {
        public static bool IsNullOrEmptyValue(this string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public static void Main(string[] args)
        {
            string name = "";

            Console.WriteLine(name.IsNullOrEmptyValue());
        }
    }
}