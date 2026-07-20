using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.SOLID_Principles.Dependency_Inversion_Principle
{
    interface IMessageService
    {
        void Send(string message);
    }
}