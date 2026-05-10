using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Generic_Collections.LinkedLists
{
    public class LinkedListDemo
    {
        public void Execute()
        {
            LinkedList<string> students = new LinkedList<string>();

            students.AddLast("John");
            students.AddLast("David");
            students.AddLast("Smith");

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void Main(string[] args)
        {
            LinkedListDemo demo = new LinkedListDemo();
            demo.Execute();
        }
    }
}