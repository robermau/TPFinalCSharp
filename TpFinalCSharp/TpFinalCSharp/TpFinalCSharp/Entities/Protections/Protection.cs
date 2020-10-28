using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    public abstract class Protection
    {
        protected int qualityShield;
        protected int aditionalShield;

        public Protection(int qualityShield)
        {
            this.qualityShield = qualityShield;
        }

        public double recieveDamage(double damage)
        {
            return damage * (1 - (qualityShield + aditionalShield )/ 100);
        }

        public abstract double recieveDamage(Damage damage);
       
        public int AditionalShield { get => aditionalShield; set => aditionalShield = value; }
    }
}
