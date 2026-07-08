using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Async_Await.Await_Keyword
{
    public class AsyncDemo
    {
        public async Task DisplayAsync()
        {
            Console.WriteLine("Before Await");

            await Task.Delay(3000);

            Console.WriteLine("After Await");
        }

        public static void Main(string[] args)
        {
            AsyncDemo demo = new AsyncDemo();

            demo.DisplayAsync().Wait();
        }
    }
}