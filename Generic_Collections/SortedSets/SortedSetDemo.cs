using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Generic_Collections.SortedSets
{
    public class SortedSetDemo
    {
        public void Execute()
        {
            SortedSet<int> numbers = new SortedSet<int>();

            numbers.Add(50);
            numbers.Add(20);
            numbers.Add(10);
            numbers.Add(40);
            numbers.Add(30);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public static void Main(string[] args)
        {
            SortedSetDemo demo = new SortedSetDemo();
            demo.Execute();
        }
    }
}