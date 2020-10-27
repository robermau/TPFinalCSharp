using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    class FireProtection : Protection
    {
        public FireProtection(double qualityShield) : base(qualityShield)
        {
        }

        public override void recieveDamage(Damage damage)
        {
            double hardDamage = 2;
            lessDamage = 0.35;

           if(damage.getType() =="Water")
            {
                return damage.doDamage() * hardDamage;
            }
            else
            {
                return da
            }
        }
    }
}
