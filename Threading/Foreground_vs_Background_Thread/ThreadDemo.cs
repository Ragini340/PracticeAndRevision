using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Threading.Foreground_vs_Background_Thread
{
    public class ThreadDemo
    {
        public void Execute()
        {
            Console.WriteLine("Background Thread Running");
            Thread.Sleep(2000);
            Console.WriteLine("Background Thread Completed");
        }

        public static void Main(string[] args)
        {
            ThreadDemo demo = new ThreadDemo();

            Thread thread = new Thread(demo.Execute);

            thread.IsBackground = true;

            thread.Start();

            Console.WriteLine("Main Thread Completed");
        }
    }
}