using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Business
{
    class DefenseInFights
    {
        public void defense(Player player)
        {
            Console.WriteLine("your dices for your aditional Shiels is:");
            player.UseDefense = true;
            player.setAditionalShield = setDices();
        }

        public void DefenseUsed()
        {
            if (playerProtect.UseDefense)
            {
                playerProtect.UseDefense = false;
            }
        }
    }
}
