using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Lambda_Expressions.Lambda_with_Parameters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Action<string> display = name => Console.WriteLine("Welcome " + name);

            display("Ragini");
        }
    }
}