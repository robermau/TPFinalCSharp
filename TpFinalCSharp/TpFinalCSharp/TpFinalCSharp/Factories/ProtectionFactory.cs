using System;
using System.Collections.Generic;
using System.Text;
using TpFinalCSharp.Entities;
namespace TpFinalCSharp.Factories
{
    class ProtectionFactory
    {
        public static Protection createProtection(Types.TypeELements typeELements)
        {
            switch (typeELements)
            {
                case Types.TypeELements.Fire:
                    FireProtection fireProtection = new FireProtection(setDices());
                    return fireProtection;
                case Types.TypeELements.Water:
                    WaterProtection waterProtection = new WaterProtection(setDices());
                    return waterProtection;
                case Types.TypeELements.Lighting:
                    LightingProtection lightingProtection = new LightingProtection(setDices());
                    return lightingProtection;
            }
        }
    }
}
