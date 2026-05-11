using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Delegates.Predicate_Delegate
{
    public class NumberChecker
    {
        public bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static void Main(string[] args)
        {
            NumberChecker checker = new NumberChecker();

            Predicate<int> predicate = checker.IsEven;

            Console.WriteLine(predicate(10));
        }
    }
}