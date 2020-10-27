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

        public override double castDamage()
        {
            return magicalDamage.doDamage();
        }

        public override double doDamage()
        {
            return fisicalDamage;
        }

        public override void recibeDamage(Damage damage)
        {
            life -= damage.doDamage();
        }
        private bool checkLife()
        {
            return life == 0;
        }
    }
}
