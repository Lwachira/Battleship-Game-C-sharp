using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShipService
{
    class TakingOnWaterState : IShipState
    {
        private Ship ship;

        public TakingOnWaterState(Ship ship)
        {
            this.ship = ship;
        }

        public string Hit()
        {
            if (ship.HP > 0)
            {
                ship.Current = ship.TakingOnWater;
                return ship.Name + " has been shot and is taking on water!";
            }
            else
            {
                ship.Current = ship.Sunk;
                return ship.Name + " has been shot and sunk!";
            }
        }
    }
}
