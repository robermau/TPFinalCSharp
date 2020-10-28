using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    
    abstract class Player
    {
        protected string name;
        protected double life;
        protected double startLife;
        protected bool isDead;
        protected double fisicalDamage;
        protected Damage magicalDamage;
        protected Protection protection;
        protected bool useDefense;
        protected int mana;

        protected Player(string name, double life,
            double fisicalDamage, Damage magicalDamage, Protection protection)
        {
            this.name = name;
            this.life = life;
            this.startLife = life;
            this.isDead = false;
            this.fisicalDamage = fisicalDamage;
            this.magicalDamage = magicalDamage;
            this.protection = protection;
            this.mana = 20;
        }

        public string getName()
        {
            return name;
        }

        public double getLife()
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
        public int getProtection()
        {
            return protection.getShield();
        }
        public int getMana()
        {
            return mana;
        }
        public string getNameMagicalAttack()
        {
            mana -= 2;
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

        public bool IsAlive()
        {
            if(life <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double doMagicalDamage()
        {
            return magicalDamage.doDamage();
        }

        public string getType()
        {
            switch (magicalDamage.getType())
            {
                case Types.TypeELements.Fire:
                    return "Fire";
                case Types.TypeELements.Water:
                    return "Water";
                case Types.TypeELements.Lighting:
                    return "Lighting";
                default:
                    return "not Founded";
            }
        }
        public double doFisicalDamage()
        {
            return fisicalDamage;
        }

        public abstract string getClass();
    }
}
