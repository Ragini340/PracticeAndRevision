using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.DataTypes
{
    public class IntegerDemo
    {
        public void ShowIntegerInfo()
        {
            int age = 25;

            Console.WriteLine("Age = " + age);
            Console.WriteLine("Minimum Value = " + int.MinValue);
            Console.WriteLine("Maximum Value = " + int.MaxValue);
            Console.WriteLine("Size = " + sizeof(int) + " Bytes");
        }

        public static void Main(string[] args)
        {
            IntegerDemo demo = new IntegerDemo();
            demo.ShowIntegerInfo();
        }
    }
}