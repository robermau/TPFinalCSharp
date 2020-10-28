
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using TpFinalCSharp.Entities;
using TpFinalCSharp.Views;
using TpFinalCSharp.Factories;

namespace TpFinalCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = SelectCharacter.Execute();
            ShowPlayer.Execute(player);

            pause();
            Console.WriteLine("your opponent will be a bot.");

            Player bot = PlayerFactory.CreatePlayer("bot", Types.TypePlayers.Paladin, ProtectionFactory.CreateProtection(Types.TypeELements.Lighting), 3, DamageFactory.createDamage(Types.TypeELements.Lighting));
            
            ShowPlayer.Execute(bot);

            pause();
            StartToFight.Execute(player, bot);
        }

        static void pause()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}




