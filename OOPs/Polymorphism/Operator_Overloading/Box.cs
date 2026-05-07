using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Polymorphism.Operator_Overloading
{
    public class Box
    {
        public int Length { get; set; }

        public static Box operator +(Box box1, Box box2)
        {
            return new Box
            {
                Length = box1.Length + box2.Length
            };
        }

        public static void Main(string[] args)
        {
            Box box1 = new Box { Length = 10 };
            Box box2 = new Box { Length = 20 };

            Box box3 = box1 + box2;

            Console.WriteLine("Length : " + box3.Length);
        }
    }
}