using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Async_Await.Multiple_Async_Methods
{
    public class AsyncDemo
    {
        public async Task Method1Async()
        {
            await Task.Delay(1000);

            Console.WriteLine("Method1 Completed");
        }

        public async Task Method2Async()
        {
            await Task.Delay(2000);

            Console.WriteLine("Method2 Completed");
        }

        public static void Main(string[] args)
        {
            AsyncDemo demo = new AsyncDemo();

            Task task1 = demo.Method1Async();
            Task task2 = demo.Method2Async();

            Task.WaitAll(task1, task2);

            Console.WriteLine("All Async Methods Completed");
        }
    }
}