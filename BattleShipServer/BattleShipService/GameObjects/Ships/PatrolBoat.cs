using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShipService
{
    class PatrolBoat : Ship
    {
        public PatrolBoat(int x, int y, bool horizontal, BoardPlacement placement) : base("Patrol Boat", 2, x, y,horizontal, placement)
        {
        }
    }
}
