using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TpFinalCSharp.Entities;

namespace TpFinalCSharp.Business
{
    class Groups
    {
        List<Player> listOfPlayers = new List<Player>();

        public void addPlayer(Player player)
        {
            listOfPlayers.Add(player);
        }
        public void deletePlayer(Player player)
        {
            listOfPlayers.Remove(player);
        }
        public Player FirstPlayer()
        {
            return listOfPlayers.First();
        }
    }
}
