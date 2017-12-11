using System.ServiceModel;


namespace BattleShipService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class GameServer : IServer
    {
        private Game gameState;

        public GameServer(Game gameState)
        {
            this.gameState = gameState;
        }

        public int connect()
        {
            if (!gameState.isFull)
            {
                Player player = gameState.AddPlayer();
                return player.UID;
            }
            else
                return -1;
        }

        public string GetPlayerInfo()
        {
            string msg = "";
            foreach (playerInfo p in gameState.GetPlayerInfo)
                msg += p.ToString() + "!";
            return msg;
        }

        public bool PlaceShip(int uid, shipPlacement placement)
        {
            return gameState.GetPlayerByUid(uid).AddShip(placement);
        }

        public bool SetName(int uid, string name)
        {
            Player player = gameState.GetPlayerByUid(uid);
            if (player != null)
            {
                gameState.GetPlayerByUid(uid).Name = name;
                return true;
            }
            return false;
        }

        public bool Shoot(int uid, int x, int y)
        {
            if(gameState.GetPlayerByUid(uid).Turn)
            {
                bool shot = gameState.GetOpponent(uid).shoot(x, y);
                if (shot)
                {
                    gameState.GetOpponent(uid).Turn = true;
                    gameState.GetPlayerByUid(uid).Turn = false;
                }
                return shot;
            }
            return false;
        }

        public void StartGame(int uid)
        {
            Player player = gameState.GetPlayerByUid(uid);
            if(!player.Ready)
                player.SetupGrid();
            gameState.Check();
        }
    }
}
