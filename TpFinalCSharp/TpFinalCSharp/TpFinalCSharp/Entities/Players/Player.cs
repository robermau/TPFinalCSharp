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
        protected bool useDefense;

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

        public string getName()
        {
            return name;
        }

        public int getLife()
        {
            return life;
        }

        public void rest()
        {
            life = startLife;
        }

        public bool UseDefense { get => useDefense; set => useDefense = value; }

        public void setAditionalShield(int shield)
        {
            protection.AditionalShield = shield;
        }
        public string getNameMagicalAttack()
        {
            return magicalDamage.getName();
        }
        public void recibeDamage(Damage damage)
        {
            life -= protection.recieveDamage(damage);
        }

        public void recibeDamage(double damage)
        {
            life -= protection.recieveDamage(damage);
        }

        public bool isAlive()
        {
            if(life > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Damage doMagicalDamage()
        {
            return magicalDamage;
        }

        public double doFisicalDamage()
        {
            return fisicalDamage;
        }

        public abstract string getType();
    }
}
