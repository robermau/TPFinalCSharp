using System;
using System.Collections.Generic;
using System.Text;
using TpFinalCSharp.Entities;
using TpFinalCSharp.Factories;
namespace TpFinalCSharp.Views
{
    class SelectCharacter
    {
        public static Player Execute()
        {
            Console.WriteLine("What class of warrior would you are?");

            Console.WriteLine("1-Warrior\n2-Mage\n3-Hunter\n4-Paladin");
            int selectionClass = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("How do your name is?");            
            string name = Console.ReadLine();
            
            Console.Clear();
            
            Console.WriteLine("now, you define what class of elements you want:");
            
            Console.WriteLine("1.Fire\n2-Water\n3-Thunder");
            int selectionElement = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now, I define your defense:");

            Protection protection;
            Damage damage;
            Console.WriteLine("your dices for Protection is:");
            switch (selectionElement)
            {
                case 1:
                    protection = ProtectionFactory.CreateProtection(Types.TypeELements.Fire);
                    break;
                case 2:
                    protection = ProtectionFactory.CreateProtection(Types.TypeELements.Water);
                    break;
                case 3:
                    protection = ProtectionFactory.CreateProtection(Types.TypeELements.Lighting);
                    break;
                default:
                    protection = ProtectionFactory.CreateProtection(Types.TypeELements.Fire);
                    break;
            }

            Console.WriteLine("your dices for Damage is:");
            switch (selectionElement)
            {
                case 1:
                    damage = DamageFactory.createDamage(Types.TypeELements.Fire);
                    break;
                case 2:
                    damage = DamageFactory.createDamage(Types.TypeELements.Water);
                    break;
                case 3:
                    damage = DamageFactory.createDamage(Types.TypeELements.Lighting);
                    break;
                default:
                    damage = DamageFactory.createDamage(Types.TypeELements.Fire);
                    break;
            }
            switch (selectionClass)
            {
                case 1:
                    return PlayerFactory.CreatePlayer(name, Types.TypePlayers.Warrior,
                        protection, DiceFactory.setDices(), damage);
                    
                case 2:
                    return PlayerFactory.CreatePlayer(name, Types.TypePlayers.Mage,
                        protection, DiceFactory.setDices(), damage);

                case 3:
                    return PlayerFactory.CreatePlayer(name, Types.TypePlayers.Hunter,
                        protection, DiceFactory.setDices(), damage);
                    
                case 4:
                    return PlayerFactory.CreatePlayer(name, Types.TypePlayers.Paladin,
                        protection, DiceFactory.setDices(), damage);
                    
                default:
                    return PlayerFactory.CreatePlayer(name, Types.TypePlayers.Paladin,
                        protection, DiceFactory.setDices(), damage);
                    
            }
        }
        
    }
}
