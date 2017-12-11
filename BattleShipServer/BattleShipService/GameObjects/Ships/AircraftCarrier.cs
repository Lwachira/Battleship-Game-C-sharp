using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShipService
{
    class AircraftCarrier : Ship
    {
        public AircraftCarrier(int x, int y, bool horizontal, BoardPlacement placement) : base("Aircraft Carrier", 5, x, y,horizontal,placement)
        {
        }
    }
}
