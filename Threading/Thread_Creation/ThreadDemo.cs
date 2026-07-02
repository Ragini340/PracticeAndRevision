using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Threading.Thread_Creation
{
    public class ThreadDemo
    {
        public void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Main(string[] args)
        {
            ThreadDemo demo = new ThreadDemo();

            Thread thread = new Thread(demo.PrintNumbers);

            thread.Start();
        }
    }
}