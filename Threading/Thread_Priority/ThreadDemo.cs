using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Threading.Thread_Priority
{
    public class ThreadDemo
    {
        public void Execute()
        {
            Console.WriteLine("Current Priority : " + Thread.CurrentThread.Priority);
        }

        public static void Main(string[] args)
        {
            ThreadDemo demo = new ThreadDemo();

            Thread thread = new Thread(demo.Execute);

            thread.Priority = ThreadPriority.Highest;

            thread.Start();
        }
    }
}