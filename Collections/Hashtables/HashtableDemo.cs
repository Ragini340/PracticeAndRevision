using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Collections.Hashtables
{
    public class HashtableDemo
    {
        public void Execute()
        {
            Hashtable employees = new Hashtable();

            employees.Add(101, "John");
            employees.Add(102, "David");
            employees.Add(103, "Smith");

            foreach (DictionaryEntry item in employees)
            {
                Console.WriteLine(item.Key + " : " + item.Value);
            }
        }

        public static void Main(string[] args)
        {
            HashtableDemo demo = new HashtableDemo();
            demo.Execute();
        }
    }
}