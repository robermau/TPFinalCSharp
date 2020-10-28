using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    class LightingDamage : Damage
    {
        public LightingDamage(string name, double qualityDamage) : base(name, qualityDamage)
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
        public override Types.TypeELements getType()
        {
            return Types.TypeELements.Lighting;
        }
    }
}
