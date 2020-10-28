using System;
using System.Collections.Generic;
using System.Text;
using TpFinalCSharp.Entities;
using TpFinalCSharp.Factories;

namespace TpFinalCSharp.Business
{
    class DefenseInFights
    {
        public static void defense(Player player)
        {
            Console.WriteLine("your dices for your aditional Shield is:");
            player.UseDefense = true;
            player.setAditionalShield(DiceFactory.setDices());
        }

        public static void DefenseUsed(Player playerProtect)
        {
            if (playerProtect.UseDefense)
            {
                playerProtect.UseDefense = false;
            }
        }
    }
}
