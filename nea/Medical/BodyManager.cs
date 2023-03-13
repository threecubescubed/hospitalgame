using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalgame
{
    class BodyManager
    {
        // properties
        private Heart heart;
        private Lungs lungs;
        int[] bloodPressure = { -1, -1 };
        public double temperature = -1;
        public double bloodSugar = -1;
        // all not set, won't update in timer unless set

        // property modifiers - between -1 and 1, multiplier for change in observations
        double heartRateModifier = 0d;
        double bloodPressureModifier = 0d;
        double tempModifier = 0d;
        double bloodSugarModifier = 0d;
        double respRateModifier = 0d;
        double satsModifier = 0d;

        public BodyManager()
        {
            heart = new Heart();
            lungs = new Lungs();
        }

        public Heart getHeart() { return heart; }
        public Lungs getLungs() { return lungs; }

        // property accessors
        public int[] getBloodPressure() { return bloodPressure; }
        public bool setBloodPressure(int systolic, int diastolic)
        {
            if (systolic <= diastolic)
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
        public double getTemperature() { return temperature; }
        public bool setTemperature(double _temperature)
        {
            if(temperature < 0d || temperature > 50d)
            {
                return false;
            }
            else
            {
                temperature = _temperature;
                return true;
            }
        }
        public double getBloodSugar() { return bloodSugar; }
        public bool setBloodSugar(double _bloodSugar)
        {
            if(bloodSugar < 0)
            {
                return false;
            }
            else
            {
                bloodSugar = _bloodSugar;
                return true;
            }
        }

        // modifier setters - between -1 and 1;
        public bool setHeartRateModifier(double _hrModifier)
        {
            if(_hrModifier < -1 || _hrModifier > 1){ return false; }
            else { heartRateModifier = _hrModifier; return true; }
        }
        public bool setBloodPressureModifier(double _bpModifier)
        {
            if (_bpModifier < -1 || _bpModifier > 1) { return false; }
            else { bloodPressureModifier = _bpModifier; return true; }
        }
        public bool setRespRateModifier(double _rrModifier)
        {
            if (_rrModifier < -1 || _rrModifier > 1) { return false; }
            else { respRateModifier = _rrModifier; return true; }
        }
        public bool setSatsModifier(double _satsModifier)
        {
            if (_satsModifier < -1 || _satsModifier > 1) { return false; }
            else { satsModifier = _satsModifier; return true; }
        }
        public bool setTempModifier(double _tempModifier)
        {
            if (_tempModifier < -1 || _tempModifier > 1) { return false; }
            else { tempModifier = _tempModifier; return true; }
        }
        public bool setbloodSugarModifier(double _bmModifier)
        {
            if (_bmModifier < -1 || _bmModifier > 1) { return false; }
            else { bloodSugarModifier = _bmModifier; return true; }
        }


        // update func: applies modifiers to properties and updates them, used for timer tick for displayed obs
        public void updateObs()
        {
            Random rnd = new Random();
            double rndVariation = (rnd.NextDouble() - 0.5d);

            int newHR = Convert.ToInt32(heart.getHeartRate() + (10 * (heartRateModifier + rndVariation)));
            heart.setHeartRate(newHR);

            for(int i = 0; i <= 1; i++)
            {
                bloodPressure[i] = Convert.ToInt32(bloodPressure[i] + (10 * (bloodPressureModifier + rndVariation)));
            }

            int newRR = Convert.ToInt32(lungs.getRespirationRate() + (2 * (respRateModifier + rndVariation)));
            lungs.setRespirationRate(newRR);
            int newSats = Convert.ToInt32(lungs.getOxygenSaturation() + (3 * (satsModifier + rndVariation)));
            lungs.setOxygenSaturation(newSats);

            temperature = temperature + (0.15 * (tempModifier + rndVariation));
            bloodSugar = bloodSugar + (0.05 * (bloodSugarModifier + rndVariation));

        }

    }
}
