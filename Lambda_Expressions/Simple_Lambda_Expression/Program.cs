using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Lambda_Expressions.Simple_Lambda_Expression
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Action message = () =>
            {
                Console.WriteLine("Lambda Expression");
            };

            message();
        }
    }
}