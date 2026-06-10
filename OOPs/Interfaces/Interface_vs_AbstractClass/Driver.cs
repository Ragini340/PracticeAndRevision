using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.OOPs.Interfaces.Interface_vs_AbstractClass
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            EmailNotification email = new EmailNotification();

            email.Display();
            email.ShowMessage();
        }
    }
}