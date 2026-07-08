using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Async_Await.AsyncMethod_Returning_Task_Generic
{
    public class Calculator
    {
        public async Task<int> AddAsync(int a, int b)
        {
            await Task.Delay(1000);

            return a + b;
        }

        public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int result = calculator.AddAsync(10, 20).Result;

            Console.WriteLine("Result : " + result);
        }
    }
}