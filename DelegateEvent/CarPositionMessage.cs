using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    public class CarPositionMessage
    {
        public void SendMessage(string name,double kiloMetr)
        {
            Console.WriteLine("машина "+name+" проехала "+kiloMetr);
        }
    }
}
