using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndRevision.Events.Simple_Event
{
    public delegate void MessageHandler();

    public class Publisher
    {
        public event MessageHandler Notify;

        public void RaiseEvent()
        {
            Notify?.Invoke();
        }
    }
}