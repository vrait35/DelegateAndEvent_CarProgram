using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    public delegate void GoHandler(double time);
    public delegate void MessageHandler(string message);
    public delegate void CarPosMessageHandler(string name, double kiloMetr);
    public class Game
    {
        public GoHandler ActionEventGo;
        public MessageHandler ActionEventMessage;
        public MessageHandler ActionEventFinish;
        public CarPosMessageHandler ActionEventCarPosition;
        public void Go(double time)
        {
            ActionEventGo?.Invoke(time);
        }

        public void StartSendMessage(string message)
        {
            ActionEventMessage?.Invoke(message);
        }

        public void FinishMessage(string message)
        {
            ActionEventFinish?.Invoke(message);
        }

        public void CarPositionSendMessage(string name,double kiloMetr)
        {
            ActionEventCarPosition?.Invoke(name,kiloMetr);
        }

    }
}
