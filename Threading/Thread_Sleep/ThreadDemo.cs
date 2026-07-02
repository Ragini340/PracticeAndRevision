using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Threading.Thread_Sleep
{
    public class ThreadDemo
    {
        public void Execute()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);

                Thread.Sleep(1000);
            }
        }

        public static void Main(string[] args)
        {
            ThreadDemo demo = new ThreadDemo();

            Thread thread = new Thread(demo.Execute);

            thread.Start();
        }
    }
}