using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    public class FireDamage : Damage
    {
        public FireDamage(string name, double qualityDamage) : base(name, qualityDamage)
        {
        }

        public override double doDamage()
        {
            return qualityDamage;
        }

        public override string getName()
        {
            return name;
        }
    }
}
