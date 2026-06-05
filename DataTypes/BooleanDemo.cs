using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.DataTypes
{
    public class BooleanDemo
    {
        public void Display()
        {
            bool isPassed = true;

            Console.WriteLine("Result Status : " + isPassed);
        }

        public static void Main(string[] args)
        {
            BooleanDemo obj = new BooleanDemo();
            obj.Display();
        }
    }
}