using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalgame
{
    class ConditionManager
    {
        private Globals.Options lastOption;
        private bool cardiacArrest;
        private readonly List<Condition> conditions = new List<Condition>();
        private readonly Patient patient;

        public ConditionManager(Patient _patient)
        {
            patient = _patient;
            DoctorGame.ChangeLastOption += ChangeLastButtonPressed;
        }

        // handles communicating with form
        public event EventHandler<WriteMessagesEventArgs> WriteMessages;
        public event EventHandler<WriteQuestionEventArgs> WriteQuestion;

        private void HandleWriteMessages(List<string> _messages)
        {
            WriteMessagesEventArgs wmargs = new WriteMessagesEventArgs()
            {
                messages = _messages
            };
            WriteMessages?.Invoke(this, wmargs);
        }

        private void HandleWriteQuestion(string _question, List<Globals.Options> _options)
        {
            WriteQuestionEventArgs wqargs = new WriteQuestionEventArgs()
            {
                message = _question,
                options = _options
            };
            WriteQuestion?.Invoke(this, wqargs);
        }

        public void ChangeLastButtonPressed(object sender, ChangeLastButtonPressedEventArgs args)
        {
            lastOption = args.LastOption;
        }

        public void AddCondition(Condition condition)
        {
            // adds condition to list of conditions, updates obs modifiers, updates visible symptoms.
            conditions.Add(condition);

            var bm = patient.GetBodyManager();
            bm.UpdateHeartRateModifier(condition.GetHeartRateModifier());
            bm.UpdateBloodPressureModifier(condition.GetBloodPressureModifier());
            bm.UpdateRespirationRateModifier(condition.GetRespirationRateModifier());
            bm.UpdateOxygenSaturationModifier(condition.GetOxygenSaturationModifier());
            bm.UpdateTemperatureModifier(condition.GetTemperatureModifier());
            bm.UpdateBloodSugarModifier(condition.GetBloodSugarModifier());

            List<string> definiteSymptoms = condition.GetDefiniteVisibleSymptoms();
            patient.SetVisibleSymptoms(definiteSymptoms);

            List<string> possibleSymptoms = condition.GetPossibleVisibleSymptoms();
            Random rnd = new Random();
            for(int i = 0; i < possibleSymptoms.Count; i++)
            {
                if(rnd.Next(0, 101) < 75)
                {
                    patient.AddVisibleSymptom(possibleSymptoms[i]);
                }
            }
        }

        public void DisplayVisibleSymptoms()
        {
            List<string> visibleSymptoms = patient.GetVisibleSymptoms();
            string message = "The patient has ";
            for(int i = 0; i < visibleSymptoms.Count; i++)
            {
                if(i == visibleSymptoms.Count - 2)
                {
                    message += visibleSymptoms[i] + ", and ";
                }
                else
                {
                    message += visibleSymptoms[i] + ", ";
                }
            }
            HandleWriteMessages(new List<string> { message });
        }
    }
}
