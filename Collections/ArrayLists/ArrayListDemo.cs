using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Collections.ArrayLists
{
        public class ArrayListDemo
        {
            public void Execute()
            {
                ArrayList list = new ArrayList();

                list.Add(100);
                list.Add("John");
                list.Add(true);

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