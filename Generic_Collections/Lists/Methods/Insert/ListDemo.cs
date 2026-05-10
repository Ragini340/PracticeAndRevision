using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Generic_Collections.Lists.Methods.Insert
{
    public class ListDemo
    {
        public void Execute()
        {
            List<string> students = new List<string>();

            students.Add("John");
            students.Add("Smith");

            students.Insert(1, "David");

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        public static void Main(string[] args)
        {
            ListDemo demo = new ListDemo();
            demo.Execute();
        }
    }
}