using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    public abstract class Protection
    {
        protected string name;
        protected double qualityShield;

        public Protection(string name, double qualityShield)
        {
            this.name = name;
            this.qualityShield = qualityShield;
        }

        public abstract double getShield();
    }
}
