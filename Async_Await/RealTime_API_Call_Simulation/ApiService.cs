using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Async_Await.RealTime_API_Call_Simulation
{
    public class ApiService
    {
        public async Task GetDataAsync()
        {
            Console.WriteLine("Calling API...");

            await Task.Delay(3000);

            Console.WriteLine("API Response Received");
        }

        public static void Main(string[] args)
        {
            ApiService service = new ApiService();

            service.GetDataAsync().Wait();
        }
    }
}