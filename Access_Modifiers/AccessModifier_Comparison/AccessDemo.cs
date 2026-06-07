using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Access_Modifiers.AccessModifier_Comparison
{
    public class AccessDemo
    {
        public int PublicValue = 10;
        private int PrivateValue = 20;
        protected int ProtectedValue = 30;
        internal int InternalValue = 40;

        public void Display()
        {
            Console.WriteLine("Public Value    : " + PublicValue);
            Console.WriteLine("Private Value   : " + PrivateValue);
            Console.WriteLine("Protected Value : " + ProtectedValue);
            Console.WriteLine("Internal Value  : " + InternalValue);
        }

        public static void Main(string[] args)
        {
            AccessDemo obj = new AccessDemo();
            obj.Display();
        }

    }
}