using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Generic_Collections.SortedDictionaries
{
    public class DictionaryDemo
    {
        public void Execute()
        {
            SortedDictionary<int, string> employees = new SortedDictionary<int, string>();

            employees.Add(103, "Smith");
            employees.Add(101, "John");
            employees.Add(102, "David");

            foreach (KeyValuePair<int, string> item in employees)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        public static void Main(string[] args)
        {
            DictionaryDemo demo = new DictionaryDemo();
            demo.Execute();
        }
    }
}