using System;
using System.Collections.Generic;
using System.Text;
using TpFinalCSharp.Entities;
namespace TpFinalCSharp.Business
{
    class LostDefense
    {
        public static void playerProtectedUseDefense(Player player)
        {
            if (player.UseDefense)
            {
                player.UseDefense = false;
                Console.WriteLine("the Player {0} lost his add defense.",player.getName());
            }
        }
    }
}
