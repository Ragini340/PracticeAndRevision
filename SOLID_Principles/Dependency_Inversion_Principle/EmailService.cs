using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Dependency_Inversion_Principle
{
    class EmailService : IMessageService
    {
        public void Send(string message)
        {
            Console.WriteLine("Email : " + message);
        }
    }
}