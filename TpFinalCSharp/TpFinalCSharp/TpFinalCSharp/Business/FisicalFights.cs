using System;
using System.Collections.Generic;
using System.Text;
using TpFinalCSharp.Entities;

namespace TpFinalCSharp.Business
{
    class FisicalFights
    {
        public static void fisicalDamagePlayerToPlayer(Player playerOne, Player playerTwo)
        {
            Console.WriteLine("The Player {0} attack first with his weapon.", playerOne.getName());
            fisicalAttackPlayer(playerOne, playerTwo);
        }

        private static void fisicalAttackPlayer(Player playerAttack, Player playerProtect)
        {
            if (playerProtect.isAlive())
            {
                playerProtect.recibeDamage(playerAttack.doFisicalDamage());
                Console.WriteLine("Player {0} has {1} of life.", playerProtect.getName(), playerProtect.getLife());
                LostDefense.playerProtectedUseDefense(playerProtect);
            }
        }
        
    }
}
