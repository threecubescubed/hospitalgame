using hospitalgame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalgame
{
    public class Condition
    {
        public string name;
        protected VitalSignModifier heartRateModifier = new VitalSignModifier();
        protected VitalSignModifier bloodPressureModifier = new VitalSignModifier();
        protected VitalSignModifier respirationRateModifier = new VitalSignModifier();
        protected VitalSignModifier oxygenSaturationModifier = new VitalSignModifier();
        protected VitalSignModifier bloodModifier = new VitalSignModifier();

        protected ConditionManager conditionManager;

        //protected DecisionNode decisionTreeNode = new DecisionNode(new List<UserInteraction>(), new Dictionary<Globals.Options, DecisionNode>(), null);

        // public DecisionNode getDecisionTree() { return decisionTreeNode; }

        public VitalSignModifier GetHeartRateModifier() { return heartRateModifier; }
        public VitalSignModifier GetBloodPressureModifier() { return bloodPressureModifier; }
        public VitalSignModifier GetRespirationRateModifier() { return respirationRateModifier; }
        public VitalSignModifier GetOxygenSaturationModifier() { return oxygenSaturationModifier; }
        public VitalSignModifier GetBloodModifier() { return bloodModifier; }

        public ConditionManager GetConditionManager() { return conditionManager; }
        public void SetConditionManager(ConditionManager _conditionManager) { conditionManager = _conditionManager; }

    }
}
