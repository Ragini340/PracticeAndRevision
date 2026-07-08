using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Async_Await.AsyncMethod_Returning_Task
{
    public class Calculator
    {
        public async Task AddAsync()
        {
            await Task.Delay(1000);

            Console.WriteLine("Result : " + (10 + 20));
        }

        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            calculator.AddAsync().Wait();
        }
    }
}