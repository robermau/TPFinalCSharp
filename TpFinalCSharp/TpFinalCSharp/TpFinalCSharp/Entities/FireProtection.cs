using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    class FireProtection : Protection
    {
        public FireProtection(string name, double qualityShield) : base(name, qualityShield)
        {
        }

        public override void getShield()
        {
            return qualityShield;
        }
    }
}
