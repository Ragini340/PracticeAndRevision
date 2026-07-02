using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Threading.Thread_Name_Property
{
    public class ThreadDemo
    {
        public void Execute()
        {
            Console.WriteLine("Thread Name : " + Thread.CurrentThread.Name);
        }

        public static void Main(string[] args)
        {
            ThreadDemo demo = new ThreadDemo();

            Thread thread = new Thread(demo.Execute);

            thread.Name = "WorkerThread";

            thread.Start();
        }
    }
}