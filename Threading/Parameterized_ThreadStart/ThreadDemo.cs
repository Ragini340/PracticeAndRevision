using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Threading.Parameterized_ThreadStart
{
    public class ThreadDemo
    {
        public void Display(object name)
        {
            Console.WriteLine("Welcome " + name);
        }

        public static void Main(string[] args)
        {
            ThreadDemo demo = new ThreadDemo();

            Thread thread = new Thread(new ParameterizedThreadStart(demo.Display));

            thread.Start("John");
        }
    }
}