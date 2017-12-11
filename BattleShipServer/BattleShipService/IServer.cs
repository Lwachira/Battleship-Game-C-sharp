using System.ServiceModel;

namespace BattleShipService
{
    [ServiceContract]
    public interface IServer
    {
        [OperationContract]
        bool SetName(int uid, string Name);
        [OperationContract]
        bool Shoot(int uid, int x,int y);
        [OperationContract]
        bool PlaceShip(int uid, shipPlacement shipPlacement);
        [OperationContract]
        void StartGame(int uid);
        [OperationContract]
        int connect();
        [OperationContract]
        string GetPlayerInfo();
    }

}
