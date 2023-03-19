using System;
using System.Collections.Generic;
using System.Text;

namespace hospitalgame
{
    class BodyManager
    {
        // properties
        private int heartRate = -1;
        int[] bloodPressure = { -1, -1 };
        private int respirationRate = -1;
        private int oxygenSaturation = -1;
        public double temperature = -1;
        public double bloodSugar = -1;
        private readonly Patient patient;
        // all not set, won't update in timer unless set

        // property modifiers - between -1 and 1, multiplier for change in observations
        double heartRateModifier = 0d;
        double bloodPressureModifier = 0d;
        double tempModifier = 0d;
        double bloodSugarModifier = 0d;
        double respRateModifier = 0d;
        double satsModifier = 0d;

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

        public BodyManager(Patient _patient)
        {
            patient = _patient;
        }


        public int[] GetBloodPressure() { return bloodPressure; }
        public bool SetBloodPressure(int systolic, int diastolic)
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

        public double GetTemperature() { return temperature; }
        public bool SetTemperature(double _temperature)
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
        public double GetBloodSugar() { return bloodSugar; }
        public bool SetBloodSugar(double _bloodSugar)
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
        public bool UpdateHeartRateModifier(double _hrModifier)
        {
            if(_hrModifier < -1 || _hrModifier > 1){ return false; }
            else { heartRateModifier += _hrModifier; return true; }
        }
        public bool UpdateBloodPressureModifier(double _bpModifier)
        {
            if (_bpModifier < -1 || _bpModifier > 1) { return false; }
            else { bloodPressureModifier += _bpModifier; return true; }
        }
        public bool UpdateRespirationRateModifier(double _rrModifier)
        {
            if (_rrModifier < -1 || _rrModifier > 1) { return false; }
            else { respRateModifier += _rrModifier; return true; }
        }
        public bool UpdateOxygenSaturationModifier(double _satsModifier)
        {
            if (_satsModifier < -1 || _satsModifier > 1) { return false; }
            else { satsModifier += _satsModifier; return true; }
        }
        public bool UpdateTemperatureModifier(double _tempModifier)
        {
            if (_tempModifier < -1 || _tempModifier > 1) { return false; }
            else { tempModifier += _tempModifier; return true; }
        }
        public bool UpdateBloodSugarModifier(double _bmModifier)
        {
            if (_bmModifier < -1 || _bmModifier > 1) { return false; }
            else { bloodSugarModifier += _bmModifier; return true; }
        }


        // update func: applies modifiers to properties and updates them, used for timer tick for displayed obs
        public void UpdateObs()
        {
            Random rnd = new Random();
            double rndVariation = (rnd.NextDouble() - 0.5d);

            heartRate += Convert.ToInt32(heartRate + (10 * (heartRateModifier + rndVariation)));
            for(int i = 0; i <= 1; i++)
            {
                bloodPressure[i] = Convert.ToInt32(bloodPressure[i] + (10 * (bloodPressureModifier + rndVariation)));
            }

            respirationRate += Convert.ToInt32(respirationRate + (2 * (respRateModifier + rndVariation)));
            oxygenSaturation += Convert.ToInt32(oxygenSaturation + (3 * (satsModifier + rndVariation)));

            temperature += (0.15 * (tempModifier + rndVariation));
            bloodSugar += bloodSugar + (0.05 * (bloodSugarModifier + rndVariation));

        }

    }
}
