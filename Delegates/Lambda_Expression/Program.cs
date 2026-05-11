using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Delegates.Lambda_Expression
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<int, int, int> add = (a, b) => a + b;

            Console.WriteLine(add(10, 20));
        }
    }
}