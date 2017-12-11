using System;

namespace BattleShipService
{
    class SunkState : IShipState
    {
        private Ship ship;

        public SunkState(Ship ship)
        {
            this.ship = ship;
        }

        public string Hit()
        {
            return ship.Name + " sunk!";
        }
    }
}
