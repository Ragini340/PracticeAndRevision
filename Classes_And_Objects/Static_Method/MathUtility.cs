using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Classes_And_Objects.Static_Method
{
    public class MathUtility
    {
        public static void ShowMessage()
        {
            Console.WriteLine("Static Method Called");
        }

        public static void Main(string[] args)
        {
            MathUtility.ShowMessage();
        }
    }
}