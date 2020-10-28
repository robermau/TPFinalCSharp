using System;
using System.Collections.Generic;
using System.Text;
using TpFinalCSharp.Business;
using TpFinalCSharp.Entities;
using TpFinalCSharp.Factories;

namespace TpFinalCSharp.Views
{
    class StartToFight
    {
        public static void Execute(Player playerOne,Player playerTwo)
        {
            int dicePlayerOne;
            int dicePlayerTwo;

            Console.WriteLine("now, we send dices to know what player go first:");
            Console.WriteLine("Dices of player One");
            dicePlayerOne = DiceFactory.setDices();
            Console.WriteLine("now the dices for player two is:");
            dicePlayerTwo = DiceFactory.setDices();

            if(dicePlayerOne >= dicePlayerTwo)
            {
                Console.WriteLine("player one attack first!");
                while (playerOne.IsAlive() && playerTwo.IsAlive())
                {
                    confirmAction(playerOne,playerTwo);
                    FisicalFights.fisicalDamagePlayerToPlayer(playerTwo, playerOne);
                }
            }
            else
            {
                Console.WriteLine("player two attack first!");
                while (playerOne.IsAlive() && playerTwo.IsAlive())
                {
                    FisicalFights.fisicalDamagePlayerToPlayer(playerTwo, playerOne);
                    confirmAction(playerOne, playerTwo);
                }
            }
        }

        private static void confirmAction(Player playerOne, Player playerTwo)
        {
            Console.WriteLine("What would you do?");
            Console.WriteLine("1-Attack with my weapon.\n2-Attack with my Magic.\n3-Active Defense.");
            int result = Convert.ToInt32(Console.ReadLine());
            switch (result)
            {
                case 1:
                    FisicalFights.fisicalDamagePlayerToPlayer(playerOne, playerTwo);
                    break;
                case 2:
                    MagicalFights.MagicalDamagePlayerToPlayer(playerOne, playerTwo);
                    break;
                case 3:
                    DefenseInFights.defense(playerOne);
                    break;
                default:
                    break;
            }
        }
    }
}
