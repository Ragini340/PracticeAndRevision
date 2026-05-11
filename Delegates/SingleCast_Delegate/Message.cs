using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Delegates.SingleCast_Delegate
{
    public delegate void MessageDelegate();

    public class Message
    {
        public void Show()
        {
            Console.WriteLine("Single Cast Delegate Invoked");
        }

        public static void Main(string[] args)
        {
            Message message = new Message();

            MessageDelegate del = message.Show;

            del();
        }
    }
}