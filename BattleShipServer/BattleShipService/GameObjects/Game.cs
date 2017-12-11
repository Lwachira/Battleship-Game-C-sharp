using System;
using System.Runtime.InteropServices;

namespace BattleShipService
{
    public class Game
    {
        private Player[] players;

        public Game()
        {
            players = new Player[2];
        }

        public bool isFull { get { return players[0] != null && players[1] != null; } }
        public int GID { get; private set; }
        public Player AddPlayer()
        {
            if (players == null)
                players = new Player[2];
            if(players[0] == null)
            {
                players[0] = new Player("Player 1", 1);
                Console.WriteLine("Player 1 joined.");
                return players[0];
            }
            else if(players[1] == null)
            {
                players[1] = new Player("Player 2", 2);
                Console.WriteLine("Player 2 joined.");
                return players[1];
            }
            else
            {
                Console.WriteLine("I'm sorry the game is already full.");
                return null;
            }
        }
        public Player GetPlayerByUid(int uid)
        {
            if (uid > 0 && uid < 3)
                return players[uid-1];
            return null;
        }
        public Player GetOpponent(int uid)
        {
            if (uid > 0 && uid < 3)
                return players[uid - 1 == 0 ? 1 : 0];
            return null;
        }
        public void Check()
        {
            if (!isFull)
                return;
            if (players[0].Ready && players[1].Ready)
                players[0].Turn = true;
        }
        public playerInfo[] GetPlayerInfo { get
            {
                if(players[0] != null && players[1] != null)
                    return new playerInfo[2] { new playerInfo() { uid= players[0].UID,name= players[0].Name, board= players[0].Board, turn = players[0].Turn }, new playerInfo() {uid= players[1].UID,name= players[1].Name,board= players[1].Board,turn= players[1].Turn } };
                else if (players[0] != null)
                    return new playerInfo[1] { new playerInfo() { uid = players[0].UID, name = players[0].Name, board = players[0].Board, turn = players[0].Turn } };
                else
                    return new playerInfo[1] { new playerInfo() { uid = players[1].UID, name = players[1].Name, board = players[1].Board, turn = players[1].Turn } };
            } }
    }
}
