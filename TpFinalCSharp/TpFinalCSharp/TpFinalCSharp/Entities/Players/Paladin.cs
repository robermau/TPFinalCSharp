using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    class Paladin : Player
    {
        public Paladin(string name, double life,
            double fisicalDamage, Damage magicalDamage, Protection protection)
            : base(name, life, fisicalDamage, magicalDamage, protection){ }

        public override string getClass()
        {
            return "Paladin";
        }
    }
}
