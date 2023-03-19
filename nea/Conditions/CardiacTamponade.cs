using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalgame
{
    class CardiacTamponade : Condition
    {
        
        public CardiacTamponade()
        {
            name = "Cardiac Tamponade";
            heartRateModifier = -0.3d;
            bloodPressureModifier = -0.3d;
            respirationRateModifier = 0.3d;
            oxygenSaturationModifier = -0.3d;
            definiteVisibleSymptoms = new List<string> { "penetrating stab wound to the central chest" };
            possibleVisibleSymptoms = new List<string> { "bulging jugular veins" };
        }

    }
}
