using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    public class StartMessage : IMessage
    {
        public void SendMessage(string startMessage)
        {
            Console.WriteLine(startMessage);
        }
    }
}
