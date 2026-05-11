using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Delegates.Multicast_Delegate
{
    public delegate void MessageDelegate();

    public class Message
    {
        public void Method1()
        {
            Console.WriteLine("Method1 Executed");
        }

        public void Method2()
        {
            Console.WriteLine("Method2 Executed");
        }

        public static void Main(string[] args)
        {
            Message message = new Message();

            MessageDelegate del = message.Method1;

            del += message.Method2;

            del();
        }
    }
}