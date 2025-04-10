using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Bicycle: Vehicle
    {
        private int maxPassengers;
        public int MaxPassengers
        {
            get;
            set;
        }
        public Bicycle (int prise, int maxspeed, int year, int maxPassengers)
        {
            this.MaxPassengers = maxPassengers;
        }
    }
}
