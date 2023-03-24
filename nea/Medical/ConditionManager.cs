using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalgame
{
    public class ConditionManager
    {
        private readonly List<Condition> conditions = new List<Condition>();
        private readonly Patient patient;

        public ConditionManager(Patient _patient)
        {
            patient = _patient;
        }

        // adds condition to list of conditions, updates obs modifiers, updates visible symptoms.
        public void AddCondition(Condition condition)
        {
            
            conditions.Add(condition);
            condition.SetConditionManager(this);

            // sets all body manager modifiers to condition modifiers
            var bodyModeller = patient.GetBodyManager().GetBodyModeller();

            bodyModeller.GetHeartRateModifier().UpdateModifier(condition.GetHeartRateModifier().GetModifier(), 1);
            bodyModeller.GetBloodPressureModifier().UpdateModifier(condition.GetBloodPressureModifier().GetModifier(), 1);
            bodyModeller.GetRespirationRateModifier().UpdateModifier(condition.GetRespirationRateModifier().GetModifier(), 1);
            bodyModeller.GetOxygenSaturationModifier().UpdateModifier(condition.GetOxygenSaturationModifier().GetModifier(), 1);
            bodyModeller.GetBloodModifier().UpdateModifier(condition.GetBloodModifier().GetModifier());
        }

    }
}
