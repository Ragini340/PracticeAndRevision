using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Custom_EventArgs
{
    public class MessageEventArgs : EventArgs
    {
        public string Message { get; set; }
    }
}