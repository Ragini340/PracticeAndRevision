using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Extension_Methods.Custom_Validation_Extension_Method
{
    public static class ValidationExtensions
    {
        public static bool IsValidEmail(this string email)
        {
            return email.Contains("@") && email.Contains(".");
        }

        public static void Main(string[] args)
        {
            string email = "ragini@gmail.com";

            Console.WriteLine(email.IsValidEmail());
        }
    }
}