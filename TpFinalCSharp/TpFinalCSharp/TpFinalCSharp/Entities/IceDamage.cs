using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    public class IceDamage : Damage
    {
        public IceDamage(string name, double qualityDamage) : base(name, qualityDamage)
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
