using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalgame
{
    public class BodyModeller
    {
        private double blood = 1d; // 0 to 1, representing scale from no blood to all blood
        private VitalSignModifier bloodModifier = new VitalSignModifier();


        // property modifiers - between -1 and 1, multiplier for change in observations
        public VitalSignModifier GetBloodModifier() { return bloodModifier; }
        private VitalSignModifier heartRateModifier = new VitalSignModifier();
        private VitalSignModifier bloodPressureModifier = new VitalSignModifier();
        private VitalSignModifier respirationRateModifier = new VitalSignModifier();
        private VitalSignModifier oxygenSaturationModifier = new VitalSignModifier();

        public VitalSignModifier GetHeartRateModifier() { return heartRateModifier; }
        public VitalSignModifier GetBloodPressureModifier() { return bloodPressureModifier; }
        public VitalSignModifier GetRespirationRateModifier() { return respirationRateModifier; }
        public VitalSignModifier GetOxygenSaturationModifier() { return oxygenSaturationModifier; }

        public double GetBlood() { return blood; }
        public bool SetBlood(double _blood)
        {
            if(blood < 0 || blood > 1)
            {
                return false;
            }
            else
            {
                blood = _blood;
                return true;
            }
        }

        public void updateModifiers()
        {
            Random rnd = new Random();

            double rndVariation = ((rnd.NextDouble() - 0.5d) * 0.1);
            heartRateModifier += rndVariation;
            rndVariation = ((rnd.NextDouble() - 0.5d) * 0.1);
            bloodPressureModifier += rndVariation;
            rndVariation = ((rnd.NextDouble() - 0.5d) * 0.1);
            respirationRateModifier += rndVariation;
            rndVariation = ((rnd.NextDouble() - 0.5d) * 0.1);
            oxygenSaturationModifier += rndVariation;
        }


    }
}
