using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Methods.Parameterless_Method
{
    public class Message
    {
        public void Display()
        {
            Console.WriteLine("Welcome to C# Methods");
        }

        public static void Main(string[] args)
        {
            Message obj = new Message();
            obj.Display();
        }
    }
}