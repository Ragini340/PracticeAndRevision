using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Generic_Collections.HashSets
{
    public class HashSetDemo
    {
        public void Execute()
        {
            HashSet<int> numbers = new HashSet<int>();

            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(20);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void Main(string[] args)
        {
            HashSetDemo demo = new HashSetDemo();
            demo.Execute();
        }
    }
}