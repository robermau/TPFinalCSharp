using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    public abstract class Damage
    {
        protected string name;
        protected double qualityDamage;
       
        protected Damage(string name, double qualityDamage)
        {
            this.name = name;
            this.qualityDamage = qualityDamage;
        }

        public abstract string getName();
        public abstract double doDamage();
        public abstract Types.TypeELements getType();
    }
}
