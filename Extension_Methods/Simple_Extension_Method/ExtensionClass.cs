using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Extension_Methods.Simple_Extension_Method
{
    public static class ExtensionClass
    {
        public static void ShowMessage(this string message)
        {
            Console.WriteLine(message);
        }

        public static void Main(string[] args)
        {
            string text = "Hello Extension Method";

            text.ShowMessage();
        }
    }
}