using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Car: Vehicle
    {
        private int power;
        public int Power
        {
            get;
            set;
        }
        public Car (int price, int maxspeed, int year, int power)
            {
            this.Power = power;
        }
    }
}
