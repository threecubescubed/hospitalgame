using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalgame
{
    class Heart
    {
        private int heartRate;

        List<Globals.Conditions> conditions;

        public int getHeartRate() { return heartRate; }
        public bool setHeartRate(int _heartRate)
        {
            if (_heartRate < 0 || _heartRate > 300)
            {
                return false;
            }
            else
            {
                heartRate = _heartRate;
                return true;
            }
        }

        public Heart()
        {
            heartRate = -1; // if not set, will not update in timer
        }

    }
}
