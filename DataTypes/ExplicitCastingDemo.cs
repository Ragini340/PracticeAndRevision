using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.DataTypes
{
    public class ExplicitCastingDemo
    {
        public void Show()
        {
            double value = 123.45;

            int result = (int)value;

            Console.WriteLine("Double Value : " + value);
            Console.WriteLine("Integer Value : " + result);
        }

        public static void Main(string[] args)
        {
            ExplicitCastingDemo obj = new ExplicitCastingDemo();
            obj.Show();
        }
    }
}