using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    internal class Computer
    {
        private State state;
        public int Volume;
        public Computer()
        {
            
        }

        public void turnOff() { }

        public void turnOn() { }
        public void volumeUp(int volume) { Volume += volume; }
        public void volumeDown(int volume) { Volume -= volume; }
    }
}
