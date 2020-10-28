using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    class FireProtection : Protection
    {
        public FireProtection(int qualityShield) : base(qualityShield) {}

        public override double recieveDamage(Damage damage)
        {
            double hardDamage = 2;
            double lightDamage = 0.35;
            double totalDamage;

            switch (damage.getType())//definimos el daño adicional.
            {
                case Types.TypeELements.Water:
                    totalDamage = damage.doDamage() * hardDamage;
                    break;
                case Types.TypeELements.Fire:
                    totalDamage = damage.doDamage() * lightDamage;
                    break;
                default:
                    totalDamage = damage.doDamage();
                    break;
            }

            return totalDamage *(1 - (qualityShield + aditionalShield) /100);
        }
    }
}
