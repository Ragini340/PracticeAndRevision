using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Async_Await.Parallel_Async_Calls
{
    public class AsyncDemo
    {
        public async Task DownloadFile1Async()
        {
            await Task.Delay(2000);

            Console.WriteLine("File1 Downloaded");
        }

        public async Task DownloadFile2Async()
        {
            await Task.Delay(1000);

            Console.WriteLine("File2 Downloaded");
        }

        public static void Main(string[] args)
        {
            AsyncDemo demo = new AsyncDemo();

            Task task1 = demo.DownloadFile1Async();
            Task task2 = demo.DownloadFile2Async();

            Task.WaitAll(task1, task2);

            Console.WriteLine("All Downloads Completed");
        }
    }
}