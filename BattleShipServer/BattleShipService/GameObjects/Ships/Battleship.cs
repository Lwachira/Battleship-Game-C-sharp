using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleShipService
{
    class Battleship : Ship
    {
        public Battleship(int x, int y, bool horizontal, BoardPlacement placement) : base("Battleship", 4, x, y,horizontal, placement)
        {

        }
    }
}
