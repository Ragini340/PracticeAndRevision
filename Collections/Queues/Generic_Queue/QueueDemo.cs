using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Collections.Queues.Generic_Queue
{
    public class QueueDemo
    {
        public void Execute()
        {
            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(10);
            numbers.Enqueue(20);
            numbers.Enqueue(30);

            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Dequeue());
            }
        }

        public static void Main(string[] args)
        {
            QueueDemo demo = new QueueDemo();
            demo.Execute();
        }
    }
}