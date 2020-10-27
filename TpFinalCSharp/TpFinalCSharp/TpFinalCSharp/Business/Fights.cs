using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Business
{
    class Fights
    {
        Groups group1 = new Groups();
        Groups group2 = new Groups();

        public Fights(Groups group1, Groups group2)
        {
            this.group1 = group1;
            this.group2 = group2;
        }

        public void Fighting()
        {

        }
    }
}
