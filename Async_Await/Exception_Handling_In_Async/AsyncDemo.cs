using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Async_Await.Exception_Handling_In_Async
{
    public class AsyncDemo
    {
        public async Task ExecuteAsync()
        {
            await Task.Delay(1000);

            throw new Exception("Something Went Wrong");
        }

        public static void Main(string[] args)
        {
            AsyncDemo demo = new AsyncDemo();

            try
            {
                demo.ExecuteAsync().Wait();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerException.Message);
            }
        }
    }
}