using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.DataTypes
{
    public class StringDemo
    {
        public void Display()
        {
            string name = "Ragini";

            Console.WriteLine("Name : " + name);
            Console.WriteLine("Length : " + name.Length);
        }

        public static void Main(string[] args)
        {
            StringDemo obj = new StringDemo();
            obj.Display();
        }
    }
}