using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalgame
{
    abstract class Condition
    {
        public string name;
        protected double heartRateModifier;
        protected double bloodPressureModifier;
        protected double respirationRateModifier;
        protected double oxygenSaturationModifier;
        protected double temperatureModifier;
        protected double bloodSugarModifier;
        protected List<string> definiteVisibleSymptoms;
        protected List<string> possibleVisibleSymptoms;

        public double GetHeartRateModifier() { return heartRateModifier; }
        public double GetBloodPressureModifier() { return bloodPressureModifier; }
        public double GetRespirationRateModifier() { return respirationRateModifier; }
        public double GetOxygenSaturationModifier() { return oxygenSaturationModifier; }
        public double GetTemperatureModifier() { return temperatureModifier; }
        public double GetBloodSugarModifier() { return bloodSugarModifier; }

        public List<string> GetPossibleVisibleSymptoms() { return possibleVisibleSymptoms; }
        public List<string> GetDefiniteVisibleSymptoms() { return definiteVisibleSymptoms; }
    }
}
