using System;
using System.Collections.Generic;
using System.Text;
using TpFinalCSharp.Entities;

namespace TpFinalCSharp.Views
{
    class ShowPlayer
    {
        public static void Execute(Player player)
        {
            Console.WriteLine("the name of {0} is {1}",player.getClass(),player.getName());
            Console.WriteLine("the fisical damage is {0}",player.doFisicalDamage());    
            Console.WriteLine("the magical type is {0}, the name is {1} and the damage is {2}",player.getType(),player.getNameMagicalAttack(),player.doMagicalDamage());
            Console.WriteLine("and the protection is {0}", player.getProtection());
        }
    }
}
