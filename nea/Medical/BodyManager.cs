using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace hospitalgame
{
    public class BodyManager
    {
        // properties
        private int heartRate = -1;
        int[] bloodPressure = { -1, -1 };
        private int respirationRate = -1;
        private int oxygenSaturation = -1;
        private readonly Patient patient;
        // all not set, won't update in timer unless set

        private BodyModeller bodyModeller;

        public BodyModeller GetBodyModeller() { return bodyModeller; }

        
        // property accessors
        public int GetHeartRate() { return heartRate; }
        public bool SetHeartRate(int _heartRate)
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


        public int[] GetBloodPressure() { return bloodPressure; }
        public bool SetBloodPressure(int systolic, int diastolic)
        {
            if (systolic <= diastolic && diastolic > 0)
            {
                return false;
            }
            else
            {
                bloodPressure[0] = systolic;
                bloodPressure[1] = diastolic;
                return true;
            }
        }
        public bool SetBloodPressure(int[] _bloodPressure)
        {
            if(_bloodPressure.Length != 2) { return false; }
            if (_bloodPressure[0] < _bloodPressure[1] && _bloodPressure[1] > 0)
            {
                return false;
            }
            else
            {
                bloodPressure[0] = _bloodPressure[0];
                bloodPressure[1] = _bloodPressure[1];
                return true;

            }
        }

        public int GetRespirationRate() { return respirationRate; }
        public bool SetRespirationRate(int _respirationRate)
        {
            if (_respirationRate < 0 || _respirationRate > 100)
            {
                return false;
            }
            else
            {
                respirationRate = _respirationRate;
                return true;
            }
        }

        public int GetOxygenSaturation() { return oxygenSaturation; }

        public bool SetOxygenSaturation(int _oxygenSaturation)
        {
            if (_oxygenSaturation < 0 || _oxygenSaturation > 100)
            {
                return false;
            }
            else
            {
                oxygenSaturation = _oxygenSaturation;
                return true;
            }
        }

        public BodyManager(Patient _patient)
        {
            patient = _patient;
            bodyModeller = new BodyModeller(this);

        }

        public BodyManager(Patient _patient, int _heartRate, int[] _bloodPressure, int _respirationRate, int _oxygenSaturation)
        {
            patient = _patient;
            heartRate = _heartRate;
            bloodPressure = _bloodPressure;
            oxygenSaturation = _oxygenSaturation;
            respirationRate = _respirationRate;
        }



        // procedures that can be done
        private bool npa = false;
        private bool opa = false;
        private bool lma = false;
        private bool intubated = false;
        private bool thoracostomyLeft = false;
        private bool thoracostomyRight = false;
        private bool thoracotomy = false;


        // if pt is in cardiac arrest or not
        private bool cardiacArrest = false;

        public void StartCardiacArrest()
        {
            cardiacArrest = true;
            heartRate = 0;
            bloodPressure = new int[] { 0, 0 };
            oxygenSaturation = 0;
            respirationRate = 0;
        }

        // update func: applies modifiers to properties and updates them, used for timer tick for displayed obs
        public void UpdateObs()
        {
            if (cardiacArrest)
            {
                return;
            }
            Random rnd = new Random();
            double rndVariation = ((rnd.NextDouble() - 0.5d) * 0.1);

            int newHR = heartRate + Convert.ToInt32(10 * (bodyModeller.GetHeartRateModifier().GetModifier() + rndVariation));
            if (newHR < 10) { StartCardiacArrest(); return; }
            SetHeartRate(newHR);
            int[] newBloodPressure = new int[2];
            for (int i = 0; i <= 1; i++)
            {
                newBloodPressure[i] = Convert.ToInt32(bloodPressure[i] + (10 * (bodyModeller.GetBloodPressureModifier().GetModifier() + rndVariation)));
                if (newBloodPressure[i] < 10) { StartCardiacArrest(); return; }
            }
            SetBloodPressure(newBloodPressure);

            SetRespirationRate(respirationRate + Convert.ToInt32(2 * (bodyModeller.GetRespirationRateModifier().GetModifier() + rndVariation)));
            SetOxygenSaturation(oxygenSaturation + Convert.ToInt32(3 * (bodyModeller.GetOxygenSaturationModifier().GetModifier() + rndVariation)));


        }

    }
}
