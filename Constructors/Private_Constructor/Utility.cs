using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Constructors.Private_Constructor
{
    public class Utility
    {
        private Utility()
        {
        }

        public static void ShowMessage()
        {
            Console.WriteLine("Private Constructor Called Indirectly");
        }

        public static void Main(string[] args)
        {
            Utility.ShowMessage();
        }

    }
}