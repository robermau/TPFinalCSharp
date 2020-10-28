using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Business
{
    class FisicalFights
    {
        public void fisicalDamagePlayerToPlayer(Player playerOne, Player playerTwo)
        {
            Console.WriteLine("The Player {0} attack first with his weapon.", playerOne.getName());
            fisicalAttackPlayer(playerOne, playerTwo);
        }

        private void fisicalAttackPlayer(Player playerAttack, Player playerProtect)
        {
            if (playerProtect.isAlive)
            {
                playerProtect.recibeDamage(playerAttack.doFisicalDamage());
                Console.WriteLine("Player {0} has {1} of life.", playerProtect.getName(), playerProtect.getLife());
            }
        }
    }
}
