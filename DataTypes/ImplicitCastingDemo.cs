using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.DataTypes
{
    public class ImplicitCastingDemo
    {
        public void Show()
        {
            int num = 100;

            long longValue = num;

            Console.WriteLine("Integer Value : " + num);
            Console.WriteLine("Long Value : " + longValue);
        }

        public static void Main(string[] args)
        {
            ImplicitCastingDemo obj = new ImplicitCastingDemo();
            obj.Show();
        }
    }
}