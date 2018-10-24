using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{   
    public class Bus:Car
    {
        public double Length { get; set; }
        public Bus() : base()
        {
            Speed = 110;
            KiloMetr = 0;
        }              
    }
}
