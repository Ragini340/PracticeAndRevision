using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Collections.Queues
{
    public class QueueDemo
    {
        public void Execute()
        {
            Queue queue = new Queue();

            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }

        public static void Main(string[] args)
        {
            QueueDemo demo = new QueueDemo();
            demo.Execute();
        }
    }
}