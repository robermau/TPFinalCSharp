using System;
using System.Collections.Generic;
using System.Text;
using TpFinalCSharp.Entities;
using TpFinalCSharp.Entities.Protections;
namespace TpFinalCSharp.Factories
{
    class ProtectionFactory
    {
        public static Protection CreateProtection(Types.TypeELements typeELements)
        {
            switch (typeELements)
            {
                case Types.TypeELements.Fire:
                    FireProtection fireProtection = new FireProtection(DiceFactory.setDices());
                    return fireProtection;
                case Types.TypeELements.Water:
                    WaterProtection waterProtection = new WaterProtection(DiceFactory.setDices());
                    return waterProtection;
                case Types.TypeELements.Lighting:
                    LightingProtection lightingProtection = new LightingProtection(DiceFactory.setDices());
                    return lightingProtection;
                default:
                    FireProtection fireProtectionDefault = new FireProtection(DiceFactory.setDices());
                    return fireProtectionDefault;
            }
        }
    }
}
