using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Async_Await.Async_Method
{
    public class AsyncDemo
    {
        public async Task ExecuteAsync()
        {
            Console.WriteLine("Async Method Started");

            await Task.Delay(2000);

            Console.WriteLine("Async Method Completed");
        }

        public static void Main(string[] args)
        {
            AsyncDemo demo = new AsyncDemo();

            demo.ExecuteAsync().Wait();
        }
    }
}