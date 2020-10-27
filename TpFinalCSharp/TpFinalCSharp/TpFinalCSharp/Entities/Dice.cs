using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Entities
{
    public class Dice
    {
        int dice;
        public Dice()
        {
            Random random = new Random();
            dice = random.Next(0, 6);
        }

        public int getDice()
        {
            return dice;
        }
    }
}
