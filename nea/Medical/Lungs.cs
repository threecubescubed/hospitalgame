using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalgame
{
    class Lungs
    {
        private int respirationRate;
        private int oxygenSaturation;

        enum Conditions
        {
            Pneumothorax,
            Haemothorax,
            Pneumohaemothorax
        }

        public Lungs()
        {
            respirationRate = -1;
            oxygenSaturation = -1;
            // if not set, won't update in timer
        }

        public int getRespirationRate() { return respirationRate; }
        public bool setRespirationRate(int _respirationRate)
        {
            if (_respirationRate < 0 || _respirationRate > 100)
            {
                return false;
            }
            else
            {
                respirationRate = _respirationRate;
                return true;
            }
        }

        public int getOxygenSaturation() { return oxygenSaturation; }

        public bool setOxygenSaturation(int _oxygenSaturation)
        {
            if (_oxygenSaturation < 0 || _oxygenSaturation > 100)
            {
                return false;
            }
            else
            {
                oxygenSaturation = _oxygenSaturation;
                return true;
            }
        }
    }
}
