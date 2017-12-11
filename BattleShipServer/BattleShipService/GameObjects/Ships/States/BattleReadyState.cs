namespace BattleShipService
{
    class BattleReadyState : IShipState
    {
        private Ship ship;

        public BattleReadyState(Ship ship)
        {
            this.ship = ship;
        }

        public string Hit()
        {
            if (ship.HP > 0)
            {
                ship.Current = ship.TakingOnWater;
                return ship.Name + " has been shot and is taking on water";
            }
            else
            {
                ship.Current = ship.Sunk;
                return ship.Name + " sunk!";
            }
        }
    }
}
