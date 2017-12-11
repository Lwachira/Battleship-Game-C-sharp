using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace BattleShipService
{
    public enum PlaceMode
    {
        None = -1,
        VBoat = 0,
        VDestroyer = 1,
        VSubmarine = 2,
        VBattleship = 3,
        VCarrier = 4,
        HBoat = 5,
        HDestroyer = 6,
        HSubmarine = 7,
        HBattleship = 8,
        HCarrier = 9
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1, Size = 12)]
    [DataContract]
    public struct shipPlacement
    {
        public shipPlacement(int x, int y, PlaceMode placement)
        {
            this.x = x;
            this.y = y;
            this.placement = placement;
        }
        [DataMember]
        public int x, y;
        [DataMember]
        public PlaceMode placement;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct playerInfo
    {
        public int uid;
        public string name;
        public int[,] board;
        public bool turn;
        public override string ToString()
        {
            string msg = uid.ToString() + "," + name + ",";
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if(board!= null)
                        msg += board[x, y].ToString() + ",";
                    else
                        msg += "-1" + ",";
                }
            }
            msg += turn.ToString();
            return msg;
        }
    }
}
