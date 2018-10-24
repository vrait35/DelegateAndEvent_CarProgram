using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    public delegate void FinishHandler(string message);
    public abstract class Car
    {
        public string Name { get; set; }
        public int Speed { get; set; } // км-часов
        public double KiloMetr { get; set; }
        public Car()
        {
            Name = this.GetType().Name; 
        }
        public void Go(double time) //ехать
        {
            KiloMetr += Speed * time;
        }
        public event FinishHandler finish;
        public bool isFinish(double length)
        {
            if (KiloMetr >=length)
            {
                finish?.Invoke(Name);
                return true;
            }
            return false;
        }        
    }
}
