using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalgame
{
    class CardiacTamponadeTrauma : Condition
    {

        public CardiacTamponadeTrauma(ConditionManager _conditionManager)
        {
            name = "Cardiac Tamponade";
            heartRateModifier.SetModifier(-0.15);
            bloodPressureModifier.SetModifier(-0.3);
            respirationRateModifier.SetModifier(0.3);
            oxygenSaturationModifier.SetModifier(-0.3);

            conditionManager = _conditionManager;
            conditionManager.AddCondition(this);
        }

    }
}
