using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Threading.Thread_Join
{
    public class ThreadDemo
    {
        public void Execute()
        {
            Console.WriteLine("Worker Thread Started");

            Thread.Sleep(3000);

            Console.WriteLine("Worker Thread Finished");
        }

        public static void Main(string[] args)
        {
            ThreadDemo demo = new ThreadDemo();

            Thread thread = new Thread(demo.Execute);

            thread.Start();

            thread.Join();

            Console.WriteLine("Main Thread Continues");
        }
    }
}