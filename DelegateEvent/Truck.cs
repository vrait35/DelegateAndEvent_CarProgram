using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{     
    public class Truck:Car
    {
        public double Massa { get; set; }
        public Truck():base()
        {
            Speed = 90;
            KiloMetr = 0;          
        }                
    }
}
