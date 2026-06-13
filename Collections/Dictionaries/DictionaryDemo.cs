using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Collections.Dictionaries
{
    public class DictionaryDemo
    {
        public void Execute()
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();

            employees.Add(101, "John");
            employees.Add(102, "David");
            employees.Add(103, "Smith");

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