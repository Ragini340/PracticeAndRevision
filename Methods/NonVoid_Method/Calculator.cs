using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Methods.NonVoid_Method
{
    public class Calculator
    {
        public int GetNumber()
        {
            return 100;
        }

        public static void Main(string[] args)
        {
            Calculator obj = new Calculator();

            int result = obj.GetNumber();

            Console.WriteLine("Returned Value = " + result);
        }
    }
}