using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    class Warrior : Player
    {
        public Warrior(string name, double life, double strartLife,
            bool isDead, double fisicalDamage, Damage magicalDamage, 
            Protection protection) : base(name, life, strartLife, 
                isDead, fisicalDamage, magicalDamage, protection)
        {
        }

        public override Damage castDamage()
        {
            return magicalDamage;
        }

        public override double doDamage()
        {
            return fisicalDamage;
        }

        
    }
}
