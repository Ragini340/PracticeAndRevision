using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Collections.ArrayLists.Add_And_Remove_Methods
{
    public class ArrayListDemo
    {
        public void Execute()
        {
            ArrayList list = new ArrayList();

            list.Add("A");
            list.Add("B");
            list.Add("C");

            list.Remove("B");

            foreach (object item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void Main(string[] args)
        {
            ArrayListDemo demo = new ArrayListDemo();
            demo.Execute();
        }
    }
}