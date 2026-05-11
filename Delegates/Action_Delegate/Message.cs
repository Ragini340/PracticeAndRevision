using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Delegates.Action_Delegate
{
    public class Message
    {
        public void Display(string message)
        {
            Console.WriteLine(message);
        }

        public static void Main(string[] args)
        {
            Message message = new Message();

            Action<string> action = message.Display;

            action("Hello Action Delegate");
        }
    }
}