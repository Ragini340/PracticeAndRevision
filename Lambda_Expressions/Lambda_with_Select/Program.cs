using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Lambda_Expressions.Lambda_with_Select
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] names =
            {
                "John",
                "David",
                "Smith"
            };

            var result = names.Select(name => name.ToUpper());

            foreach (string name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}