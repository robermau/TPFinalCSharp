using System;
using System.Collections.Generic;
using System.Text;
using TpFinalCSharp.Entities;

namespace TpFinalCSharp.Business
{
    class MagicalFights 
    {
        public static void MagicalDamagePlayerToPlayer(Player playerOne, Player playerTwo)
        {
            Console.WriteLine("The Player {0} attack with {1}.", playerOne.getName(),playerOne.getNameMagicalAttack());
            magicalAttackPlayer(playerOne, playerTwo);
        }

        private static void magicalAttackPlayer(Player playerAttack, Player playerProtect)
        {
            if (playerProtect.IsAlive())
            {
                playerProtect.recibeDamage(playerAttack.doMagicalDamage());
                Console.WriteLine("Player {0} has {1} of life.", playerProtect.getName(), playerProtect.getLife());
                Console.WriteLine("the mana of player {0} is {1}",playerProtect.getName(),playerProtect.getMana());
                LostDefense.playerProtectedUseDefense(playerProtect);
            }
        }
    }
}
