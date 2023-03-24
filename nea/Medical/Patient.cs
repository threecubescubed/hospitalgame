using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalgame
{
    public class Patient
    {
        private readonly BodyManager bodyManager;
        private readonly ConditionManager conditionManager;
        private List<string> visibleSymptoms;
        public UserInterfacer userInterfacer = new UserInterfacer();

        public Patient()
        {
            bodyManager = new BodyManager(this);
            conditionManager = new ConditionManager(this);
        }

        public Patient(int _heartRate, int[] _bloodPressure, int _respirationRate, int _oxygenSaturation)
        {
            bodyManager = new BodyManager(this, _heartRate, _bloodPressure, _respirationRate, _oxygenSaturation);
            conditionManager = new ConditionManager(this);
        }

        public BodyManager GetBodyManager() { return bodyManager; }
        public ConditionManager GetConditionManager() { return conditionManager; }

        public List<string> GetVisibleSymptoms() { return visibleSymptoms; }
        public void SetVisibleSymptoms(List<string> _symptoms)
        {
            visibleSymptoms = _symptoms;
        }
        public void AddVisibleSymptom(string symptom)
        {
            visibleSymptoms.Add(symptom);
        }

    }
}
