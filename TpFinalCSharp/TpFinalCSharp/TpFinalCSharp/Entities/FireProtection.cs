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

        public override double recieveDamage(Damage damage)
        {
            double hardDamage = 2;
            double lessDamage = 0.35;
            double totalDamage;
            switch (damage.getType())
            {
                case "Water":
                    totalDamage = damage.doDamage() * hardDamage;
                    break;
                case "Curarse":
                    totalDamage = damage.doDamage() * lessDamage;
                    break;
                default:
                    totalDamage = damage.doDamage();
                    break;
            }

            return totalDamage;
        }
    }
}
