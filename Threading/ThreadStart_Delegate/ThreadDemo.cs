using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Threading.ThreadStart_Delegate
{
    public class ThreadDemo
    {
        public void Display()
        {
            Console.WriteLine("Thread Started");
        }

        public static void Main(string[] args)
        {
            ThreadDemo demo = new ThreadDemo();

            Thread thread = new Thread(new ThreadStart(demo.Display));

            thread.Start();
        }
    }
}