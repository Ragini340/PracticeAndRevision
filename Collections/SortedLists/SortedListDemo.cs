using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Collections.SortedLists
{
    public class SortedListDemo
    {
        public void Execute()
        {
            SortedList list = new SortedList();

            list.Add(103, "Smith");
            list.Add(101, "John");
            list.Add(102, "David");

            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        public static void Main(string[] args)
        {
            SortedListDemo demo = new SortedListDemo();
            demo.Execute();
        }
    }
}