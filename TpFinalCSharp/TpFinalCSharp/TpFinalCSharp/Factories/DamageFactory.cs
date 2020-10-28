using System;
using System.Collections.Generic;
using System.Text;
using TpFinalCSharp.Entities;

namespace TpFinalCSharp.Factories
{
    class DamageFactory
    {
        public static Damage createDamage(Types.TypeELements typeELements)
        {
            switch (typeELements)
            {
                case Types.TypeELements.Fire:
                    FireDamage fireDamage = new FireDamage("Firebolt", setDices());
                    return fireDamage;
                case Types.TypeELements.Water:
                    WaterDamage waterDamage = new WaterDamage("Waterwipe", setDices());
                    return waterDamage;
                case Types.TypeELements.Lighting:
                    LightingDamage lightingDamage = new LightingDamage("Thundershock", setDices());
                    return lightingDamage;
            }
        }
    }
}
