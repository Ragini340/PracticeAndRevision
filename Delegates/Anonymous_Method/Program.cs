using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Delegates.Anonymous_Method
{
    public delegate void MessageDelegate();

    public class Program
    {
        public static void Main(string[] args)
        {
            MessageDelegate del = delegate ()
            {
                Console.WriteLine("Anonymous Method Executed");
            };

            del();
        }
    }
}