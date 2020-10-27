using System;
using System.Collections.Generic;
using System.Text;
using TpFinalCSharp.Entities;

namespace TpFinalCSharp.Factories
{
    class PlayerFactory
    {   //TODO. Terminar factory.
        public Player createPlayer(string name, Type type)
        {
            switch (type)
            {
                case Type.Warrior:
                    Warrior warrior = new Warrior(name,100,);
                    break;
                default:
                    break;
            }
        }
    }

    public enum Type {Warrior}
}
