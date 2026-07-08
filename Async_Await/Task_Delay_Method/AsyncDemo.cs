using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Async_Await.Task_Delay_Method
{
    public class AsyncDemo
    {
        public async Task ExecuteAsync()
        {
            Console.WriteLine("Waiting...");

            await Task.Delay(3000);

            Console.WriteLine("Completed");
        }

        public static void Main(string[] args)
        {
            AsyncDemo demo = new AsyncDemo();

            demo.ExecuteAsync().Wait();
        }
    }
}