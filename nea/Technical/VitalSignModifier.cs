using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospitalgame
{
    public class VitalSignModifier
    {
        
        private double modifier = 0;

        public double GetModifier() { return modifier; }

        public bool SetModifier(double _modifier)
        {
            if(_modifier > -1 && _modifier < 1)
            {
                modifier = _modifier;
                return true;
            }
            else { return false; }
        }

        public bool UpdateModifier(double _modifier, double _strength)
        {
            double newVal = modifier + (_modifier * _strength);
            if(newVal > -1 && newVal < 1)
            {
                modifier = newVal;
                return true;
            }
            else { return false; }
        }

        public bool UpdateModifier(double _modifier)
        {
            double newVal = modifier + _modifier;
            if(newVal > -1 && newVal < 1)
            {
                modifier = newVal; return true;
            }
            else { return false; }
        }
    }
}
