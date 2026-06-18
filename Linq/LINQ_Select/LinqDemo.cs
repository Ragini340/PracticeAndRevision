using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Linq.LINQ_Select
{
    public class LinqDemo
    {
        public void Execute()
        {
            string[] names =
            {
                "John",
                "David",
                "Smith"
            };

            var result = names.Select(name => name.ToUpper());

            foreach (string name in result)
            {
                Console.WriteLine(name);
            }
        }

        public static void Main(string[] args)
        {
            LinqDemo demo = new LinqDemo();
            demo.Execute();
        }
    }
}