using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum4
{
    class WaterGalon
    {
        private int volume = 0; //mili
        private int volumeOneCup = 250;

        public WaterGalon(int volume) {
            this.volume = volume;
        }

        public Boolean isAviable()
        {
            return volume >= volumeOneCup;
        }

        public void addWater(int volume)
        {
            this.volume += volume; 
        }

        public int makeOneCup()
        {
            this.volume = this.volume - this.volumeOneCup;
            return volumeOneCup;
        }

        public int getVolume()
        {
            return this.volume;
        }

    }

}
