using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalgame
{
    class Patient
    {
        private readonly string firstName;
        private readonly string lastName;
        private readonly int age;
        private readonly BodyManager bodyManager;
        private readonly ConditionManager conditionManager;
        private List<string> visibleSymptoms;

        public Patient(string _firstName, string _lastName, int _age)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;

            bodyManager = new BodyManager(this);
            conditionManager = new ConditionManager(this);
        }

        public Patient(string _firstName, string _lastName, int _age, List<string> visibleSymptoms)
        {
            firstName = _firstName;
            lastName = _lastName;
            age = _age;

            bodyManager = new BodyManager(this);
            conditionManager = new ConditionManager(this);
        }

        public BodyManager GetBodyManager() { return bodyManager; }
        public ConditionManager GetConditionManager() { return conditionManager; }

        public string[] GetName()
        {
            return new string[2] { firstName, lastName };
        }
        public int GetAge() { return age; }

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
