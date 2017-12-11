using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShipService
{
    class Destroyer : Ship
    {
        public Destroyer(int x, int y, bool horizontal, BoardPlacement placement) : base("Destroyer", 3, x, y,horizontal, placement)
        {

        }
    }
}
