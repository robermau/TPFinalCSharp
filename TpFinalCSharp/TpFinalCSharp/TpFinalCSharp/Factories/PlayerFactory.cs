using System;
using System.Collections.Generic;
using System.Text;
using TpFinalCSharp.Entities;
using TpFinalCSharp.Entities.Protections;

namespace TpFinalCSharp.Factories
{
    class PlayerFactory
    {   
        public static Player createPlayer(string name, Types.TypePlayers typePlayer,Protection armor, double fisicalAttack,Damage magicalAttack)
        {
            int life = 100;
            switch (typePlayer)
            {
                case Types.TypePlayers.Warrior:
                    Warrior warrior = new Warrior(name,life,fisicalAttack,magicalAttack,armor);
                    return warrior;
                case Types.TypePlayers.Mage:
                    Mage mage = new Mage(name,life,fisicalAttack,magicalAttack,armor);
                    return mage;
                case Types.TypePlayers.Hunter:
                    Hunter hunter = new Hunter(name,life,fisicalAttack,magicalAttack,armor);
                    return hunter;
                case Types.TypePlayers.Paladin:
                    Paladin paladin = new Paladin(name,life,fisicalAttack,magicalAttack,armor);
                    return paladin;
            }
        }
    }
}
