using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    abstract class Player
    {
        protected string name;
        protected double life;
        protected double strartLife;
        protected bool isDead;
        protected double fisicalDamage;
        protected Damage magicalDamage;
        protected Protection protection;

        protected Player(string name, double life,
            double fisicalDamage, Damage magicalDamage, Protection protection)
        {
            this.name = name;
            this.life = life;
            this.strartLife = life;
            this.isDead = false;
            this.fisicalDamage = fisicalDamage;
            this.magicalDamage = magicalDamage;
            this.protection = protection;
        }

        public void recibeDamage(Damage damage)
        {
            life -= protection.recieveDamage(damage);
        }
        public abstract double doDamage();
        public abstract Damage castDamage();
    }
}
