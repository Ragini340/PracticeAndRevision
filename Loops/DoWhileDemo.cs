using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Loops
{
    public class DoWhileDemo
    {
        public void Execute()
        {
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 5);
        }

        public static void Main(string[] args)
        {
            DoWhileDemo obj = new DoWhileDemo();
            obj.Execute();
        }
    }
}