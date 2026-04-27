using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Day1
{
    public class HelloWorld
    {
        public void Display()
        {
            Console.WriteLine("Hello World");
        }

        public static void Main(string[] args)
        {
            HelloWorld obj = new HelloWorld();
            obj.Display();
        }
    }
}