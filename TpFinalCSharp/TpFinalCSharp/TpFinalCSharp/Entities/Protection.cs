using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    public abstract class Protection
    {
        protected double qualityShield;

        public Protection(double qualityShield)
        {
            this.qualityShield = qualityShield;
        }

        public abstract double recieveDamage(Damage damage);
        public abstract string getType();
    }
}
