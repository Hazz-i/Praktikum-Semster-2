using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum4
{
    class CoffeMachine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;

        public CoffeMachine(CoffePowder powder, WaterGalon galon)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
        }

        public string makeEspreso()
        {
            if (!this.waterGalon.isAviable())
                return "Sorry, the water is empety";

            if (!this.coffePowder.isAviable())
                return "Yey! your coffe is ready";

            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your coffe is redy";
        }

        public string checkingAvaibility()
        {
            return $"the water :{this.waterGalon.getVolume()} and the cofe powder : {this.coffePowder.getNetto()}";
        }

    }
}
