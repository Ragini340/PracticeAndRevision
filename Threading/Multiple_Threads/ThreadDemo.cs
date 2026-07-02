using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Threading.Multiple_Threads
{
    public class ThreadDemo
    {
        public void Method1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread 1 : " + i);
            }
        }

        public void Method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Thread 2 : " + i);
            }
        }

        public static void Main(string[] args)
        {
            ThreadDemo demo = new ThreadDemo();

            Thread thread1 = new Thread(demo.Method1);
            Thread thread2 = new Thread(demo.Method2);

            thread1.Start();
            thread2.Start();
        }
    }
}