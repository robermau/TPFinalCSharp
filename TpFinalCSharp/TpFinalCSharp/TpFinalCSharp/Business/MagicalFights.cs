using System;
using System.Collections.Generic;
using System.Text;

namespace TpFinalCSharp.Business
{
    class MagicalFights : Fights
    {
        public void MagicalDamagePlayerToPlayer(Player playerOne, Player playerTwo)
        {
            Console.WriteLine("The Player {0} attack first with {1}.", playerOne.getName(),playerOne.getMagicalName());
            magicalAttackPlayer(playerOne, playerTwo);
        }

        private void magicalAttackPlayer(Player playerAttack, Player playerProtect)
        {
            if (playerProtect.isAlive)
            {
                playerProtect.recibeDamage(playerAttack.doMagicalDamage());
                Console.WriteLine("Player {0} has {1} of life.", playerProtect.getName(), playerProtect.getLife());
            }
        }
    }
}
