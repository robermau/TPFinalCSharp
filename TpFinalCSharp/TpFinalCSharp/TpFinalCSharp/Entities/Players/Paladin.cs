using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    class Paladin
    {
        public Paladin(string name, double life,
            double fisicalDamage, Damage magicalDamage, Protection protection)
            : base(name, life, fisicalDamage, magicalDamage, protection){ }

        public override string getType()
        {
            return "Paladin";
        }
    }
}
