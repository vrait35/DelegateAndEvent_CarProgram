using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    public class FinishMesssage : IMessage
    {
        public void SendMessage(string name)
        {
            Console.WriteLine("Победитель  машина: "+name);
        }
    }
}
